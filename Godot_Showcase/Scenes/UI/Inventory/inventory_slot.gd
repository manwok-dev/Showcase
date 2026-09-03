class_name inv_slot_class extends Control

@export var item: item_resource = null

signal this_slot(slot:inv_slot_class ,item: item_resource)	## Emitter: Inventory_slot, Connector: Inventory, Listener: Inventory

@onready var btn: TextureButton = $TextureButton
@onready var txtr: TextureRect = $TextureRect
@onready var label: Label = $Label
@onready var standard_pos: Vector2 = position

var filled_slot_txtr = preload("res://Assets/Inventory/Sprite-0002.png")
var empty_slot_txtr = preload("res://Assets/Inventory/Sprite-0001.png")
var max_stack: int = 0
var capacity: int = 0

## inserts item into slot, sets button & rect texture
func insert_item(ressource):
	item = ressource
	btn.texture_normal = filled_slot_txtr
	txtr.texture = item.texture
	label.text = str(item.amount)
	max_stack = item.max_stack
	capacity = max_stack - item.amount

## removes item from slot, sets button & rect texture
func remove_item():
	label.text = "0"
	item = null
	btn.texture_normal = empty_slot_txtr
	txtr.texture = null

func stack_items(z: int):
	item.amount += z
	label.text = str(item.amount)

## Emits signal with this slots information, used in inventory.gd
func _on_texture_button_button_down() -> void:
	emit_signal("this_slot", self, item)
