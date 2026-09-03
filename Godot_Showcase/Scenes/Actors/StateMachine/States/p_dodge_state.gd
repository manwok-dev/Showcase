extends State

@export var dodge_speed: int = 4	## Set the dodge speed
@export var dodge_cooldown: int = 4	## Dodge Cooldown
@export var dodge_time: float = 0.1	## How long it takes for the dodge to complete
	
func enter():
	print("dodge")

func process_physics(_delta):
	var direction = Input.get_vector('left', 'right', 'up', 'down')	# Get direction
	if Input.is_action_pressed("action") and not on_cooldown:	# If action key pressed and the state is not on cooldown
		actor.velocity = direction * actor.stats.speed * dodge_speed	# What to do aka dodge
		await get_tree().create_timer(dodge_time).timeout	# Await the dodge_time
		actor.velocity = Vector2.ZERO	# Set character velocity back to zero
		cooldown(dodge_cooldown)	# Set the cooldown for the state
	elif direction != Vector2.ZERO:	# Elif input for direction, change to walk state
		signal_change_state.emit(new_state_1)
	else:	# otherwise change to idle state
		signal_change_state.emit(new_state_2)
