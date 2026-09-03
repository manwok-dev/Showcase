class_name player_stats extends actor_stats_class

signal stat_has_changed(effect: effect_type_class)	## Emitter:player_stats, Connector: vitals_ui, Listener: vitals_ui
signal took_dot_effect(runtime: effect_runtime_class)	## Emitter: player_stats, Connector: player, Listener: effect_manager


## Get the current vitals as a 2D Dict and returns them
func get_vitals_dict() -> Dictionary:
	return{
		"hp": {"max": health_max, "current": health},
		"mp": {"max": mana_max, "current": mana},
		"sp": {"max": stamina_max, "current": stamina}
		}

## Calls check_type and changes specified type's value
func stat_changer(effect: effect_type_class, is_dot_effect: bool = false) -> void:
	var var_name = check_type(effect)
	var current_value = get(var_name)
	if is_dot_effect:
		current_value += effect.dot_tick_amount
	else:
		current_value += effect.ot_amount
		if effect.dot_duration > 0.0:
			emit_signal("took_dot_effect", effect)	# Connected via player to effect manager
	set(var_name, current_value)
	emit_signal("stat_has_changed", effect, current_value)	# Signal listened to by the vitals_ui

## Checks the type and subtype of effect
func check_type(effect: effect_type_class) -> String:
	var var_name := ""
	match effect.type:
		"hp": var_name = "health"
		"mp": var_name = "mana"
		"sp": var_name = "stamina"
	if effect.subtype == "max":
		var_name += "_max"
	return var_name
