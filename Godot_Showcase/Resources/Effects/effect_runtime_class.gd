class_name effect_runtime_class

var effect: effect_type_class
var elapsed := 0.0
var tick_accumulator := 0.0
var rest_t := 0.0

func set_effect(_effect: effect_type_class) -> void:
	pass

func rest_time() -> void:
	rest_t -= effect.dot_tick_rate
