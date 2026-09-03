extends Control


func set_txtr(new_txtr: Texture) -> void:
	var txtr = $VBoxContainer/TextureRect
	txtr.texture = new_txtr

func set_lbl(new_txt) -> void:
	var lbl := $VBoxContainer/Label
	lbl.text = String.num(new_txt)
