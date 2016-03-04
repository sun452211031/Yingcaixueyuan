using UnityEngine;
using System.Collections;

public class changdushuru : MonoBehaviour {
	public void zhuanhuan()
	{
		UILabel label = gameObject.GetComponent<UILabel>();//获取NGUI UILable组件
		if(label.text != "")
		{
			count.countchangdu = float.Parse (label.text);//Text字符转数字
		}
		Debug.Log("长度（L）数值为 "+count.countchangdu);
	}
}
