using UnityEngine;
using System.Collections;

public class baohucenghoudushuru : MonoBehaviour {
	public void zhuanhuan()
	{
		UILabel label = gameObject.GetComponent<UILabel>();//获取NGUI UILable组件
		if(label.text != "")
		{
			count.countbaohucenghoudu = float.Parse (label.text);//Text字符转数字
			GameObject Countpeijinlv = GameObject.Find("Jisuan/Countpeijinlv");//获得计算配筋率物体
			peijinlv script = Countpeijinlv.GetComponent<peijinlv> ();
			script.jisuan ();
		}
		Debug.Log("保护层厚度（dc）数值为 "+count.countbaohucenghoudu);
	}
}
