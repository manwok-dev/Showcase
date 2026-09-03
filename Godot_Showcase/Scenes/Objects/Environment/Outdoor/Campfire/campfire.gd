extends Node2D

@export var stats: object_stats


# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	pass # Replace with function body.

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(_delta: float) -> void:
	pass

func _on_hurtbox_area_entered(area: Area2D) -> void:
	if !area.is_in_group("Campfire"):
		pass

#func _on_hitbox_area_entered(area: Area2D) -> void:
	#if !area.is_in_group("Campfire"):
		#area.take_damage(stats.effect)

func _on_hitbox_area_exited(area: Area2D) -> void:
	#if !area.is_in_group("Campfire"):
		#area.take_dot(stats.effect)
		pass
