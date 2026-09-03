@tool
class_name enemy_class extends actor_class

@export var txtr_res: actor_txtr_class:
	set(value):
		txtr_res = value
		_update_visual()
		
@onready var sprite := $Sprite2D
@onready var coll_shape := $CollisionArea
@onready var detect_area := $DetectionArea
@onready var nav_agent := $PathfinderNavigationAgent


var target :CharacterBody2D

func _physics_process(_delta: float) -> void:
	move_and_slide()

func _ready() -> void:
	_update_visual()
	if state_machine:
		state_machine.connect("signal_anim_play", play_anim)
	if anim_player:
		anim_player.connect("animation_has_finished", state_machine.animation_finished)

func _update_visual():
	if not Engine.is_editor_hint() and not is_inside_tree():
		return
	if txtr_res and sprite:
		sprite.texture = txtr_res.idle_txtr
	if txtr_res and coll_shape:
		coll_shape.shape.radius = txtr_res.coll_radius
		coll_shape.shape.height = txtr_res.coll_height
		collision_layer = txtr_res.coll_layer
		collision_mask = txtr_res.coll_mask

func _on_detection_area_body_entered(body: Node2D) -> void:
	if body.is_in_group("Player"):
		target = body

func _on_detection_area_body_exited(_body: Node2D) -> void:
	target = null

func target_in_range() -> bool:
	nav_agent.target_position = target.global_position
	if nav_agent.distance_to_target() <= 40:
		return true
	else:
		return false

func move_to_target():
	var next_pos = nav_agent.get_next_path_position()
	var dir = (next_pos - global_position).normalized()
	velocity = dir * stats.speed * 5

func play_anim(animation_name: String) -> void:
	var dir = (target.global_position - global_position).normalized() 
	anim_player.play_animation("Player", animation_name, dir)
