using UnityEngine;
using System.Collections;

public class dianji : MonoBehaviour {
	void OnPress() //NGUI长按事件
	{
	 if(kubaifangyiqi.presspanduan==true)//UI OnPress事件状态判断
		{
         tuodong script = gameObject.GetComponent<tuodong>();
	     script.enabled = true;//物体拖动脚本触发
		 
		 kubaifangyiqi.presspanduan=false;//UI OnPress事件状态判断
		 kubaifangyiqi.enterpanduan=false;//鼠标OnMouseEnter事件状态判断
		}
	}

}
