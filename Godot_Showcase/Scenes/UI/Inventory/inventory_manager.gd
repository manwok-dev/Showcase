extends Node

@export var player_inventory: inventory_class
var inventory_tscn := preload("res://Scenes/UI/Inventory/inventory.tscn")
var interact_inv :inventory_class

var effect_manager: effect_manager_class

## The item pickup function, called from items when they are picked up
func item_pickup(item: item_resource):
	player_inventory.insert_new_item(item)

## Opens inventory when "inventory" action pressed
func _unhandled_key_input(_event: InputEvent) -> void:
	if Input.is_action_pressed("inventory"):
		if player_inventory.visible == true:
			player_inventory.visible = false
		else:
			player_inventory.visible = true

func create_interact_inventory(rows: int, columns: int, items_array: Array[item_resource]):
	interact_inv = inventory_tscn.instantiate()
	interact_inv.inventory_rows = rows
	interact_inv.inventory_columns = columns
	add_child(interact_inv)
	for i in items_array:
		interact_inv.insert_new_item(i)
	toggle_interact_inventory()

func delete_interact_inventory():
	if interact_inv:
		interact_inv.queue_free()

func interact_with_inventory(rows: int, columns: int, items_array: Array[item_resource]):
	if !interact_inv:
		create_interact_inventory(rows, columns, items_array)
	else:
		toggle_interact_inventory()

func toggle_interact_inventory():
	if !interact_inv.visible:
		interact_inv.visible = true
	else:
		interact_inv.visible = false
