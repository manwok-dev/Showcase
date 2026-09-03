extends StaticBody2D

signal interact_inventory_signal(rows: int, columns: int, item_array: Array[item_resource])
signal delete_inventory_signal

@export var rows: int	## Rows of chest
@export var columns: int	## Columns of chest
@export var items_array: Array[item_resource]

var user: CharacterBody2D	## Keeps track of wheather or not a valid user is in range

func _ready() -> void:
	ui_auto.connect_interact_inventory(self)

## Calls ui to create the inventory overlay for chest
func _unhandled_key_input(event: InputEvent) -> void:
	if event.is_action_pressed("interact") and user:
		emit_signal("interact_inventory_signal", rows, columns, items_array)

func _on_interact_area_body_entered(body: Node2D) -> void:
	if body.is_in_group("Player"):
		user = body

func _on_interact_area_body_exited(body: Node2D) -> void:
	if user == body:
		emit_signal("delete_inventory_signal")
		user = null
