class_name player_class extends actor_class

@onready var anim_tree_walk_state_machine = anim_tree["parameters/MoveStateMachine/playback"]

func _ready() -> void:
	stats.connect("took_dot_effect", effect_manager.apply_effect)
	effect_manager.connect("took_dot_damage", stats.stat_changer)
	ui_auto.connect_effect_manager(effect_manager)
	if state_machine:
		state_machine.connect("signal_anim_play", play_animation)
	if anim_root:
		anim_root.connect("animation_has_finished", state_machine.animation_finished)
		anim_tree.active = true

func move_player(direction) -> void:
	velocity = direction * (stats.speed * 10)
	update_walk_anim(direction)
	anim_tree.set("parameters/MoveStateMachine/Walk/blend_position", direction)
	move_and_slide()

func update_walk_anim(direction) -> void:
	if direction != Vector2.ZERO:
		anim_tree_walk_state_machine.travel("Walk")
	else: 
		anim_tree_walk_state_machine.travel("Idle")

func _on_hurtbox_area_entered(area: Area2D) -> void:
	var effect = area.stats.effect
	stats.stat_changer(effect)

## Calls the animation players play_animation()-Method with the animation_name and a direction
func play_animation(animation_name: String):
	var dir = (get_global_mouse_position() - global_position).normalized()
	anim_root.play_animation(stats.name, animation_name, dir)
