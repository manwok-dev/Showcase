class_name AnimationPlayerRootClass extends Node

signal animation_has_finished	## Signal sent by AnimationPlayerRoot, Connector: Actors, Listener: States

@onready var anim_player := $AnimationPlayer


func play_animation(anim_library: String, anim_name: String, anim_dir: Vector2) -> void:
	if anim_player.get_animation_library(anim_library) and anim_player.get_animation_library(anim_library).get_animation(anim_name):
		# Convert to 0 → 2PI
		var angle = fposmod(anim_dir.angle(), TAU)
		# 8 directions = 45° per sector
		anim_player.play(anim_library + "/" + anim_name + match_angle(angle))
		

## Adds Suffix to animation ie: _up_left, _down_right
func match_angle(angle) -> String :
		var sector = int(round(angle / (PI / 4.0))) % 8
		match sector:
			0: return "_right"
			1: return "_down_right"
			2: return "_down"
			3: return "_down_left"
			4: return "_left"
			5: return "_up_left"
			6: return "_up"
			7: return "_up_right"
		return "" # fallback

## Sends out "animation_has_finished"-Signal
func _on_animation_player_animation_finished(_anim_name: StringName) -> void:
	emit_signal("animation_has_finished")
	anim_player.play("RESET")

func _on_attack_hurtbox(_size: int, _pos: Vector2) -> void:
	print("change")
