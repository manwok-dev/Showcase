class_name hurtbox_class extends Area2D



# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(_delta: float) -> void:
	pass

func take_damage(type: String, subtype: String, damage: int) -> void:
	var parent = self.get_parent()
	if "stats" in parent:
		parent.stats.stat_changed(type, subtype, damage)
	else:
		print("nothing to damage")

func take_dot(effect: effect_type_class) -> void:
	var parent = self.get_parent()
	if "effect_manager" in parent:
		parent.effect_manager.apply_effect(effect)
	else:
		print("nothing to damage")
