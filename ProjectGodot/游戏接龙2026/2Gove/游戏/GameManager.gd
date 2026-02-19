extends Node

const config_file_path = "res://2Gove/配置/接龙Godot-工作表1.csv"
var config = Config.new()

func _ready() -> void:
	# 加载配置
	config.load_config(config_file_path)
	
