extends TextureRect


@onready var standard_pos: Vector2 = position

# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	Control.MOUSE_FILTER_IGNORE

func change_phys_process(value:bool):
	self.set_physics_process(value)
	if !value:
		position = standard_pos

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _physics_process(_delta: float) -> void:
	position = get_parent().get_local_mouse_position()
