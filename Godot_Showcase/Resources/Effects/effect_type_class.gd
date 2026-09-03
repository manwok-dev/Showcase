class_name effect_type_class extends Resource

@export var name: String	## Effect name
@export var txtr: Texture	## Effect textxure

@export_enum("hp", "mp", "sp") var type: String	## What type does this effect affect
@export_enum("current", "max") var subtype: String	## What subtype does this effect affect

# One time effect
@export var ot_amount: int	## Amount that is affected by effect (- for negative)

# Damage over time effect
@export var dot_duration: float = 0.0	## Duration in Seconds
@export var dot_tick_rate: float = 0.0	## How many ticks per Second
@export var dot_tick_amount: float = 0.0	## How much damage per tick
