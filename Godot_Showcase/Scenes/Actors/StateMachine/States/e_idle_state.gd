extends State


func enter():
	print("enemy idle")

func process_physics(_delta):
	if actor.target:
		if actor.target_in_range():
			change_state(new_state_2)	# Change to "Attack"-State
		else:
			change_state(new_state_1)	# Change to "Engage"-State
