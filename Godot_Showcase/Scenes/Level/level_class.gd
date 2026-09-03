class_name LevelClass extends Node

# Called when the node enters the scene tree for the first time.
func _ready():
	item_connector()

## Connect signal "item_pickup_signal" of items in group "Items" ui_auto.item_pickup()
func item_connector()-> void:
	var children = get_children()
	for i in children.size():
		if children[i].is_in_group("Items"):
			children[i].connect("item_pickup_signal", ui_auto.inventory_manager.item_pickup)
