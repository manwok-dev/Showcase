extends State

func enter():
	print("walk")
	
func exit():
	actor.velocity = Vector2.ZERO
	actor.update_walk_anim(Vector2.ZERO)

func process_physics(_delta):
	var direction = Input.get_vector('left', 'right', 'up', 'down')
	# If input = action change to "Dodge"-State
	if Input.is_action_just_pressed("action"):
		signal_change_state.emit(new_state_1)
	elif Input.is_action_just_pressed("attack"):
		signal_change_state.emit(new_state_3)
	elif direction != Vector2.ZERO:
		actor.move_player(direction)
	else:	# Change state to "Idle"-State
		actor.velocity = Vector2.ZERO
		signal_change_state.emit(new_state_2)
