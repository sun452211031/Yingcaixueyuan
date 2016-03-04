using UnityEngine;
using System.Collections;

public class jinru1 : MonoBehaviour {
    public string mainOBJname="";//实例化物体名称查找
	public Transform parentOBJ;//设置实例物父物体
	public GameObject dianjiUI;//对应的UI
	public int intpanduan;//物件摆设顺序判断输入数值
	void OnMouseEnter() //鼠标进入事件
	{
	  if(kubaifangyiqi.shangpanduan>=intpanduan)//下方 物件摆设顺序判断
		{
	     tuodong script = dianjiUI.gameObject.GetComponent<tuodong>();
	     script.enabled = false;//鼠标tuodong脚本关闭
	     
		 GameObject clone = GameObject.Find ("/"+mainOBJname);
		 if(clone!=null)
			{
	         clone.transform.position = transform.position;//实例化物体坐标匹配
		     clone.name = gameObject.name;//重置名称 防止同名销毁
			 clone.transform.parent = parentOBJ;//设置实例物父物体 便于统一删除
			
			 kubaifangyiqi.shangpanduan+=1;//下方 物件摆设顺序判断
			
			 kubaifangyiqi.enterpanduan = true;//鼠标OnMouseEnter事件状态判断
			
			 Destroy(gameObject);//删除当前物体
			}
		}
	}

}
