@tool
extends Node2D

signal item_pickup_signal(item)

@export var resource: item_resource:
	set(value):
		resource = value
		_update_visual()

@export var player_stat: player_stats

@onready var sprite: Sprite2D = $Sprite2D
@onready var main: Node2D
@onready var item_area: PackedScene = load("res://Scenes/Objects/Item/item_area.tscn")
@onready var pickup_area: Area2D
@onready var dmg_area: Area2D

## Set the items values in the ready function
func _ready():
	_update_visual()

## Updates the items visuals, sets sprite and pickup effects
func _update_visual():
	if resource and sprite:
		sprite.texture = resource.texture
	if not Engine.is_editor_hint() and not is_inside_tree():
		return
	if resource.is_pickable:
		var area = item_area.instantiate()
		self.add_child(area)
		pickup_area = area
		area.connect("body_entered", pickup_item)
	if resource.has_pickup_effect:
		var area = item_area.instantiate()
		self.add_child(area)
		dmg_area = area
		area.connect("body_entered", on_enter)

## On pickup send signal to main.item_pickup()
func pickup_item(_body):
	item_pickup_signal.emit(resource)
	queue_free()

## Effect, on area entered, get type, subtype & amount of effect
func on_enter(_body):
	player_stat.stat_changer(resource.effect)
