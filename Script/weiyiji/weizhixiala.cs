using UnityEngine;
using System.Collections;

public class weizhixiala : MonoBehaviour {
public GameObject xialabeijing;//下拉显示物体
	void OnClick()
	{
		if(kuweiyiji.xialastate == true)
		{
			xialabeijing.SetActive(true);
			kuweiyiji.xialastate = false;
		}
		else
		{
			xialabeijing.SetActive(false);
			kuweiyiji.xialastate = true;
		}
	}
}
