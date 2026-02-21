using RG.Basic;
using RG.Zeluda;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class MapItem : MonoBehaviour
{
	public int index;
	public Image img_icon;
	public Text lbl_name;
	public MapCA mapCA;
	public void Init(MapCA map)
	{
		mapCA = map;
		img_icon.sprite = Resources.Load<Sprite>(map.icon);
		lbl_name.text = map.name;
	}
	public void OnClick()
	{
		UIManager uiManager = CBus.Instance.GetManager(ManagerName.UIManager) as UIManager;
		uiManager.ClosePanel("MapPanel");
		TransitionPanel tp = uiManager.OpenFloat("TransitionPanel") as TransitionPanel;
		tp.StartTransition(() => {
			SceneLoadManager slm = CBus.Instance.GetManager(ManagerName.SceneLoadManager) as SceneLoadManager;
			slm.Load(mapCA);
		});
	}
}
