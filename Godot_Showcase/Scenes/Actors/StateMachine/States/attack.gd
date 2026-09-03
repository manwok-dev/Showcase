extends State


# Called when the node is entered
func enter():
	get_parent().emit_signal("signal_anim_play", "attack")


func _on_animation_finished() -> void:
	emit_signal("signal_change_state", new_state_1)
