using UnityEngine;
using System.Collections;

public class kuandushuru : MonoBehaviour {
public void zhuanhuan()
	{
		UILabel label = gameObject.GetComponent<UILabel>();//获取NGUI UILable组件
		if(label.text != "")
		{
			count.countkuandu = float.Parse (label.text);//Text字符转数字
			GameObject Countpeijinlv = GameObject.Find("Jisuan/Countpeijinlv");//计算配筋率物体
			peijinlv script = Countpeijinlv.GetComponent<peijinlv> ();
			script.jisuan ();
		}
		Debug.Log("宽度(b)数值为 "+count.countkuandu);
	}
}
