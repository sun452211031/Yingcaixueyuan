using UnityEngine;
using System.Collections;

public class gaodushuru : MonoBehaviour {
public void zhuanhuan()
	{
		UILabel label = gameObject.GetComponent<UILabel>();//获取NGUI UILable组件
		if(label.text != "")
		{
			count.countgaodu = float.Parse (label.text);//Text字符转数字
			GameObject Countpeijinlv = GameObject.Find("Jisuan/Countpeijinlv");//计算配筋率物体
			peijinlv script = Countpeijinlv.GetComponent<peijinlv> ();
			script.jisuan ();
		}
		Debug.Log("高度（h）数值为 "+count.countgaodu);
	}
}
