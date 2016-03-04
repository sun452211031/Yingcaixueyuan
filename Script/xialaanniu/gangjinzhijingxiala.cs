using UnityEngine;
using System.Collections;

public class gangjinzhijingxiala: MonoBehaviour {
	public GameObject xianshianniu;//显示选择内容框
	public GameObject beijing;//显示隐藏开关
	void OnClick() //赋予内容框字符
	{
		UILabel xianshianniulabel = xianshianniu.gameObject.GetComponent<UILabel>();//获取NGUI UILable组件
		xianshianniulabel.text = gameObject.name;
		kugangjinzhijing.kugangjinzhijingString = gameObject.name;
		canshu.canshuUIstate = true;
		GameObject jisuan = GameObject.Find("Jisuan/Countgangjinzhijing");//获得计算钢筋直径物体
		if(jisuan!=null)
		{
			gangjinzhijing script = jisuan.GetComponent<gangjinzhijing> ();//获取计算最小配筋率函数
			script.jisuan ();//钢筋直径(D) 计算
		}
		beijing.SetActive (false);
	}
}
