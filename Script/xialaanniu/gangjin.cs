using UnityEngine;
using System.Collections;

public class gangjin: MonoBehaviour {
	public GameObject xianshianniu;//显示选择内容框
	public GameObject beijing;//显示隐藏开关
	void OnClick() //赋予内容框字符
	{
		UILabel xianshianniulabel = xianshianniu.gameObject.GetComponent<UILabel>();//获取NGUI UILable组件
		xianshianniulabel.text = gameObject.name;
		minpeijinlv.gangjinString = gameObject.name;
		canshu.canshuUIstate = true;
		GameObject jisuan = GameObject.Find("Jisuan/Countzuixiaopeijinlv");//获得计算最小配筋率物体
		if(jisuan!=null)
		{
			zuixiaopeijinlv script = jisuan.GetComponent<zuixiaopeijinlv> ();//获取计算最小配筋率函数
			script.jisuan ();//最小配筋率(p min) 查询
		}
		GameObject jisuan2 = GameObject.Find("Jisuan/Countyibusilongb");//获得计算 伊布斯隆b 物体
		if(jisuan2!=null)
		{
			yibusilongb script = jisuan2.GetComponent<yibusilongb> ();//获取计算 伊布斯隆b 函数
			script.jisuan ();//伊布斯隆b 查询
		}
		GameObject jisuan3 = GameObject.Find("Jisuan/Countaifuy");//获得计算 Fy 物体
		if(jisuan3!=null)
		{
			aifuy script = jisuan3.GetComponent<aifuy> ();//获取计算 Fy 函数
			script.jisuan ();//Fy 查询
		}
		beijing.SetActive (false);
	}
}
