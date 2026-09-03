class_name effect_manager_class extends Node

signal created_dot_effect(runtime: effect_runtime_class)	## Emitter: effect_manager_class, Connector: UI_Auto, Listener: Health UI´s
signal updated_dot_effect(effect_name: String, rest_time: float)		## Emitter: effect_manager_class, Connector: UI_Auto, Listener: Health UI´s
signal deleted_dot_effect(effect_name: String)		## Emitter: effect_manager_class, Connector: UI_Auto, Listener: Health UI´s
signal took_dot_damage(effect: effect_type_class, bool)		## Emitter: effect_manager_class, Connector: Player, Listener: Player_Stats

var active_effects: Dictionary = {}	## Array with all the currently active effects

## Loops through effect array. If tick counter is reached do the effect
## After loop filter the effect array and remove effects that are done
func _process(delta: float) -> void:
	for eff_name in active_effects:
		var eff_runtime = active_effects[eff_name]
		eff_runtime.elapsed += delta
		eff_runtime.tick_accumulator += delta
		if eff_runtime.tick_accumulator >= eff_runtime.effect.dot_tick_rate:
			eff_runtime.tick_accumulator = 0
			eff_runtime.rest_time()
			emit_signal("updated_dot_effect", eff_name, eff_runtime.rest_t)
			emit_signal("took_dot_damage", eff_runtime.effect, true)
			if eff_runtime.rest_t <= 0:
				emit_signal("deleted_dot_effect", eff_name)
				active_effects.erase(eff_name)

## Checks if effect_name already in active_effects dictionary
## If true update effect timer 
## If false Create effect runtime class and add the effect into. Add the new element to effect list
func apply_effect(new_effect: effect_type_class) -> void:
	if active_effects.has(new_effect.name):
		var new_rest_t = active_effects[new_effect.name].rest_t + new_effect.dot_duration
		active_effects[new_effect.name].rest_t = new_rest_t
		emit_signal("updated_dot_effect", new_effect.name, new_rest_t)
	else:
		var runtime = effect_runtime_class.new()
		runtime.effect = new_effect
		runtime.rest_t = new_effect.dot_duration
		emit_signal("created_dot_effect", runtime)
		active_effects[new_effect.name] = runtime
