extends Node

@onready var plot = $UI/Plot as Plot

var curtain: Curtain

func _ready() -> void:
	plot.on_choice_selected.connect(_choice_select)
	
	curtain = GameManager.config.get_curtain(100)
	plot.load_data(curtain)

func _choice_select(i: int):
	# curtain = GameManager.config.get_curtain(curtain.choices[i].jumpCurtain)
	curtain = GameManager.config.get_curtain(i)
	plot.load_data(curtain)
