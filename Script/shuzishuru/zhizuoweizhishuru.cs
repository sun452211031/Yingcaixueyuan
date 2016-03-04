using UnityEngine;
using System.Collections;

public class zhizuoweizhishuru : MonoBehaviour {
	public void zhuanhuan()
	{
		UILabel label = gameObject.GetComponent<UILabel>();//获取NGUI UILable组件
		if(label.text != "")
		{
			count.countzhizuoweizhi = float.Parse (label.text);//Text字符转数字
		}
		Debug.Log("支座位置（a）数值为 "+count.countzhizuoweizhi);
	}
}
