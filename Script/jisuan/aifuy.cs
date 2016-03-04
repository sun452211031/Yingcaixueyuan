using UnityEngine;
using System.Collections;

public class aifuy : MonoBehaviour {
public void jisuan()
	{
		if (minpeijinlv.gangjinString!="") 
		{
			switch (minpeijinlv.gangjinString)
			{
			case"HPB300": 
					count.countaifuy=270.0f;    
				break;
			case"HRB335": 
					count.countaifuy=300.0f;       
				break;
			case"HRBF335": 
					count.countaifuy=300.0f;   
				break;
			case"HRB400": 
					count.countaifuy=360.0f;    
				break;
			case"HRBF400": 
					count.countaifuy=360.0f;  
				break;
			case"RRB400": 
					count.countaifuy=360.0f;   
				break;
			case"HRB500": 
					count.countaifuy=435.0f;  
				break;
			case"HRBF500": 
					count.countaifuy=435.0f;   
				break;
			}
			GameObject jisuan = GameObject.Find("Jisuan/Countliangpohuaixingshi");//获得计算梁破坏形式物体
			if(jisuan!=null)
			{
				liangpohuaixingshi script = jisuan.GetComponent<liangpohuaixingshi> ();//获取计算梁破坏形式函数
				script.jisuan ();//梁破坏形式 计算
			}
			Debug.Log("Fy 查询结果为"+ count.countaifuy);
		}
	}
}
