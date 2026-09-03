class_name item_resource extends object_resource

@export var name: String
@export var texture: Texture
@export var max_stack: int = 1
@export var amount: int = 1

@export var is_pickable: bool = false

@export var effect: effect_type_class

@export var has_pickup_effect: bool = false
