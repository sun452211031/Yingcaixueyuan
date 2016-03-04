using UnityEngine;
using System.Collections;

public class weiyijixialaanniu : MonoBehaviour {
public GameObject weizhiUI;//位置UI物体
public GameObject xialabeijing;//下拉显示物体
	void OnClick() 
	{
	  UILabel weizhiLabel = weizhiUI.gameObject.GetComponent<UILabel>();
	  UILabel wutiLabel = gameObject.GetComponent<UILabel>();
	  weizhiLabel.text = wutiLabel.text;
	  kuweiyiji.weiyijiweizhi = wutiLabel.text;
	
	  xialabeijing.SetActive(false);
	  kuweiyiji.xialastate = true;
		
	  Debug.Log ("位移计位置 名为  "+kuweiyiji.weiyijiweizhi);
	}
}
