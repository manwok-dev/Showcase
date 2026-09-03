extends CanvasLayer

@export var inventory_manager: Node

@onready var main: Node2D

var effect_manager: effect_manager_class

func connect_interact_inventory(node: Node) -> void:
	node.connect("interact_inventory_signal", inventory_manager.interact_with_inventory)
	node.connect("delete_inventory_signal", inventory_manager.delete_interact_inventory)

## Connects the current effect manager to the stat_ui's via signals
func connect_effect_manager(em: effect_manager_class) -> void:
	for i in get_children():
		if i.is_in_group("stat_ui"):
			if effect_manager:
				effect_manager.disconnect("created_dot_effect", i.create_effect_visual())
				effect_manager.connect("updated_dot_effect", i.update_effect_visual())
				effect_manager.connect("deleted_dot_effect", i.delete_effect_visual())
			else:
				em.connect("created_dot_effect", i.create_effect_visual)
				em.connect("updated_dot_effect", i.update_effect_visual)
				em.connect("deleted_dot_effect", i.delete_effect_visual)
	effect_manager = em
