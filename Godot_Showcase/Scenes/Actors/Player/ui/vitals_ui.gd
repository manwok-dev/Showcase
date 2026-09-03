class_name health_ui extends Control

@export var txtr_res: ui_container_class
@export var player_stat: player_stats

@onready var full_txtr = txtr_res.full_container
@onready var half_txtr = txtr_res.half_container
@onready var empty_txtr = txtr_res.empty_container
@onready var vBox := $HBoxContainer/HBoxContainer
@onready var container = preload("res://Scenes/Actors/Player/ui/container.tscn")
@onready var effBox := $HBoxContainer/GridContainer
@onready var eff_visual = preload("res://Scenes/Actors/Player/ui/effect_visuals.tscn")
@onready var max_amount: int = 0
@onready var current_amount: int
@onready var amount_array: Array

var dot_effect_dict: Dictionary

# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	player_stat.connect("stat_has_changed", check_type)
	var p_stat = player_stat.get_vitals_dict()[txtr_res.type]
	current_amount = p_stat["current"]
	set_max_amount(p_stat["max"])
	update_amount(current_amount)
	

## Sets the max amount of containers
func set_max_amount(amount: int) -> void:
	var diff = amount - max_amount
	if diff > 0:
		for i in (diff/2):
			var slot = container.instantiate()
			vBox.add_child(slot)
			amount_array.append(slot)
			slot.texture = empty_txtr
	if diff < 0:
		for i in (-diff/2):
			var slot = amount_array[-1]
			slot.queue_free()
			amount_array.pop_back()
	max_amount = amount

## Checks if the current type matches the type of changed object, otherwise ignores. 
## Checks which subtype it is
func check_type(effect: effect_type_class, new_amount: int) -> void:
	var p_stat = player_stat.get_vitals_dict()[txtr_res.type]
	current_amount = p_stat["current"]
	if effect.type == txtr_res.type:
		if effect.subtype == "max":
				set_max_amount(new_amount)
		elif effect.subtype == "current":
			update_amount(new_amount)

## Updates the textures to match the current amount
func update_amount(new_amount: int) -> void:
	# Checks that the new_amount cant be bigger than max_amount
	if new_amount > max_amount:
		new_amount = max_amount
	for i in (max_amount/2):
		if i < (new_amount/2):
			amount_array[i].texture = full_txtr
		# Set last heart to half if the new_amount % 2 = > 0
		elif (new_amount % 2) > 0 and i == (new_amount/2):
			amount_array[i].texture = half_txtr
		else:
			amount_array[i].texture = empty_txtr

## Creates an instance of eff_visuals and sets texture & label
func create_effect_visual(runtime: effect_runtime_class) -> void:
	if runtime.effect.type == txtr_res.type:
		var visual = eff_visual.instantiate()
		visual.set_txtr(runtime.effect.txtr)
		visual.set_lbl(runtime.rest_t)
		vBox.add_child(visual)
		dot_effect_dict[runtime.effect.name] = visual

func update_effect_visual(eff_name: String, rest_time: float) -> void:
	if dot_effect_dict.has(eff_name):
		var visual = dot_effect_dict[eff_name]
		visual.set_lbl(rest_time)

func delete_effect_visual(eff_name: String) -> void:
	if dot_effect_dict.has(eff_name):
		var runtime = dot_effect_dict[eff_name]
		runtime.queue_free()
		dot_effect_dict.erase(eff_name)
