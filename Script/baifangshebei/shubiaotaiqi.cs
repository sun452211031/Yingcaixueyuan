using UnityEngine;
using System.Collections;

public class shubiaotaiqi : MonoBehaviour {
	public GameObject dianjiUI;//对应UI
	void Update() 
    {
        if(Input.GetMouseButtonUp(0))//鼠标抬起事件
		{
		  tuodong script = dianjiUI.gameObject.GetComponent<tuodong>();
	      script.enabled = false;//UI tuodong脚本关闭
		  
		  kubaifangyiqi.presspanduan=true;//UI OnPress事件状态判断
		  
		  if(kubaifangyiqi.enterpanduan==false)//鼠标OnMouseEnter事件状态判断
			{
			 Destroy(gameObject);//如果没有进入指定摆放位置，抬起后销毁当前物体
		    }
		  else
			{
			 Destroy(GetComponent("shubiaotaiqi"));//如果进入指定摆放位置，销毁当前物体shubiaotaiqi脚本防止删除
			}
		}
	}
}
