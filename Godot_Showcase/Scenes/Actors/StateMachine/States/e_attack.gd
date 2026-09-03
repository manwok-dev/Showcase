extends State


func enter():
	animation_has_finished = false
	get_parent().emit_signal("signal_anim_play", "attack")
	cooldown(1)

func process_physics(_delta):
	print("attack")
	if actor.target:
		if !actor.target_in_range():
			change_state(new_state_2)	# Change to "Engage"-State
		elif !on_cooldown and animation_has_finished:
			animation_has_finished = false
			get_parent().emit_signal("signal_anim_play", "attack")
			cooldown(cooldown_time)
	else:
		change_state(new_state_1)	#Change to "Idle-State

func _on_animation_finished() -> void:
	animation_has_finished = true
