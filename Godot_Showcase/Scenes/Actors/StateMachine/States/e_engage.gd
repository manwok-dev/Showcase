extends State

func enter():
	print("enemy detected")
	actor.move_to_target()
	cooldown(0.5)

func process_physics(_delta):
	if !on_cooldown:
		if actor.target and !actor.target_in_range():
			actor.move_to_target()
			cooldown(0.5)
		else:
			_on_target_reached()

func _on_target_reached():
	change_state(new_state_1)	# Change to "Idle"-State

func exit():
	actor.velocity = Vector2.ZERO
