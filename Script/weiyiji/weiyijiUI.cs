using UnityEngine;
using System.Collections;

public class weiyijiUI : MonoBehaviour {
  void OnClick()
	{
	    GameObject[] weiyijizu = GameObject.FindGameObjectsWithTag("weiyijiUI");
		foreach(GameObject a in weiyijizu)//所有位移计UI为黑
		{
		   UILabel otherLabel = a.GetComponent<UILabel>();
		   otherLabel.color = Color.black;
		}
		UILabel thisLabel = gameObject.GetComponent<UILabel>();//当前选择位移计UI为蓝
		thisLabel.color = Color.blue;
		
		kuweiyiji.weiyijishanchu = gameObject.name;//设置删除选择的物体
		
	}
}
