using UnityEngine;
using System.Collections;

public class jialidianweizhishuru : MonoBehaviour {
	public void zhuanhuan()
	{
		UILabel label = gameObject.GetComponent<UILabel>();//获取NGUI UILable组件
		if(label.text != "")
		{
			count.countjialidianweizhi = float.Parse (label.text);//Text字符转数字

			GameObject jisuan = GameObject.Find("Jisuan/Countjixianwanju");//获得计算可加载最大载荷物体
			jixianwanju script = jisuan.gameObject.GetComponent<jixianwanju>();//获得计算可加载最大载荷脚本
			if(count.countliangpohuaixingshi!="")
			{
				script.kejiazaizuidazaihe();
			}
		}
		Debug.Log("加力点位置（L1）数值为 "+count.countjialidianweizhi);
	}
}
