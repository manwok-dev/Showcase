extends inventory_class

signal item_picked_from_slot_signal	##Emitter: Inventory1, Connector: InventoryManager, Listener: Inventory2

@export var inventory_rows: int
@export var inventory_columns: int

@onready var grid: GridContainer = $GridContainer
@onready var inventory_slot = load("res://Scenes/UI/Inventory/inventory_slot.tscn")
@onready var inventory_array: Array
@onready var drag_preview: Sprite2D = $DragPreview

var inv_size: int
var item1: item_resource
var slot1: inv_slot_class
var is_previewing: bool = false

func _ready():
	self.visible = false
	grid.columns = inventory_columns
	inv_size = inventory_columns * inventory_rows
	for i in inv_size:
		var inv_slot = inventory_slot.instantiate()
		grid.add_child(inv_slot)
		inventory_array.append(inv_slot)
		inv_slot.connect("this_slot", slot_actions)

func _process(_delta: float) -> void:
	if is_previewing:
		drag_preview.position = get_local_mouse_position()

## Trys to insert new item into inventory
func insert_new_item(item):
	for i in inv_size:
		var slot = inventory_array[i]
		if slot.item == null:
			slot.insert_item(item)
			break
		elif slot.item.name == item.name and item.amount <= slot.capacity:
			slot.stack_items(item.amount)
			break
		elif i == inv_size -1: 
			print("no space")
			break

## Set preview image and previewing = true
func preview(texture):
	if texture != null:
		drag_preview.visible = true
		drag_preview.texture = texture
		is_previewing = true
	else:
		is_previewing = false
		drag_preview.visible = false

 ## Handles slot actions
func slot_actions(slot, item):
	#Selects first slot if no slot is selected
	if slot1 == null and item != null:
		slot1 = slot
		item1 = item
		preview(item1.texture)
	else:
		#If second slot is empty insert item into new and remove from old slot
		if item == null and slot1 != null:
			slot1.remove_item()
			slot.insert_item(item1)
		#Swap items in the two slots if there are two items
		if item != null and slot1 != null:
			var slot2 = slot
			var item2 = item
			slot1.remove_item()
			slot2.remove_item()
			slot1.insert_item(item2)
			slot2.insert_item(item1)
		# Resets preview, slot1, item1
		preview(null)
		slot1 = null
		item1 = null
