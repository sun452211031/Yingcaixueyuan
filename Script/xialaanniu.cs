using UnityEngine;
using System.Collections;

public class xialaanniu : MonoBehaviour {
	public GameObject xianshianniu;//显示选择内容框
	public GameObject beijing;
	void OnClick() //赋予内容框字符
	{
		UILabel xianshianniulabel = xianshianniu.gameObject.GetComponent<UILabel>();//获取NGUI UILable组件
		xianshianniulabel.text = gameObject.name;
		beijing.SetActive (false);
		canshu.canshuUIstate = true;
	}

}
