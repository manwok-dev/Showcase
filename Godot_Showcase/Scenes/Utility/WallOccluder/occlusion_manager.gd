extends Node

@export var tilemap_layer: TileMapLayer
@onready var mat = tilemap_layer.material
@onready var occlusion_count: int = 0

func _ready() -> void:
	for i in get_children():
		i.connect("occlusion_zone_entered_signal", add_occlusion)
		i.connect("occlusion_zone_exited_signal", subtr_occlusion)

func add_occlusion() -> void:
	occlusion_count += 1
	check_occlusion()

func subtr_occlusion() -> void:
	occlusion_count -= 1
	check_occlusion()
	
func check_occlusion() -> void:
	if occlusion_count == 0 && mat:
		mat.set_shader_parameter("player_behind", false)
	elif occlusion_count > 0 && mat:
		mat.set_shader_parameter("player_behind", true)
