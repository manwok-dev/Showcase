extends State


func enter():
	print("idle")
	
func process_physics(_delta):
	if Input.is_action_pressed("left") or Input.is_action_pressed("right") or Input.is_action_pressed("up") or Input.is_action_pressed("down"):
		signal_change_state.emit(new_state_1)	#Change to "Walk"-State
	elif Input.is_action_pressed("attack"):
		signal_change_state.emit(new_state_2)	## Change to "Attack"-State
