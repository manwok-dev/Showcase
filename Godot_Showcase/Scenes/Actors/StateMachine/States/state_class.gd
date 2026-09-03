class_name State extends Node	# New class names State

signal signal_change_state(new_state)	## Signal emitted when the state should be changed
var actor: CharacterBody2D	## The entity ie player/monster
var on_cooldown: bool = false	## Is state on cooldown?

@export var state_name: String ## Name of the state, used for changing the state
@export var new_state_1: String
@export var new_state_2: String
@export var new_state_3: String
@export var cooldown_time: float = 0 	# Standard cooldown time for States in Sek = 0.0

@onready var timer_load = preload("res://Scenes/Utility/Timer/timer.tscn")

var timer
var animation_has_finished: bool = true

func init_state(parent: CharacterBody2D):	## What happens when state is initialized. Same for every State. Only change in state_class.gd
	actor = parent
	enter()

func enter():	## What to do when state is entered. Can be overwritten by states
	print("enter not defined")

func exit():	## What to do when state is exited
	print("exit not defined")

func process(_delta):	## Processing _physics. Passed on from StateMachine
	pass

func process_physics(_delta): ## Processing _physics_process. Passed on from StateMachine
	pass

func handle_input(_event):	## Handles player inputs inside the states
	pass

func change_state(state_new: String):	## Called when state should be changed
	signal_change_state.emit(state_new)	# Call signal with the new state name

## Cooldown funktion
func cooldown(time: float):
	if !timer:
		timer = timer_load.instantiate()
		self.add_child(timer)
	on_cooldown = true
	timer.start(time)
	print("cd started")
	await timer.timeout
	on_cooldown = false
	print("cd ended")

func _on_animation_finished() -> void:
	pass
