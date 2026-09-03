class_name WallOccluderClass extends Node2D

signal occlusion_zone_entered_signal
signal occlusion_zone_exited_signal

func _on_area_2d_body_entered(_body):
	emit_signal("occlusion_zone_entered_signal")

func _on_area_2d_body_exited(_body):
	emit_signal("occlusion_zone_exited_signal")
