class_name StateMachineClass extends Node

signal enemy_spotted(enemy: CharacterBody2D) ## Enemy spotted signal. Sender: Engage State, Connector/Listener: Enemy Parent Node
signal signal_anim_play(animation_name: String)	## Emitter: Stats, Connector: Actor, Listener: Actor

@export var initial_state: State

@onready var parent: CharacterBody2D = self.get_parent()
@onready var current_state: State
@onready var state_dict: Dictionary

# Called when the node enters the scene tree for the first time.
func _ready():
	current_state = initial_state	# Set current state to initial state
	current_state.init_state(parent)	# Initiate current state
	for i in get_children():	# Lap over children and connect their signal_change_state Signal with change_state() function
		i.signal_change_state.connect(change_state)
		state_dict[i.name] = i

func _process(delta):
	current_state.process(delta)

func _physics_process(delta):
	current_state.process_physics(delta)

func _unhandled_input(event):
	current_state.handle_input(event)

func change_state(new_state_name: String):	# Change state if new_state is not on cooldown
	if state_dict.has(new_state_name):
		var new_state = state_dict[new_state_name]
		if !new_state.on_cooldown:
			current_state.exit()
			current_state = new_state
			current_state.init_state(parent)

func animation_finished():
	current_state._on_animation_finished()
