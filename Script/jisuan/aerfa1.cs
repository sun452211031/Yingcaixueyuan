using UnityEngine;
using System.Collections;

public class aerfa1 : MonoBehaviour {
	public void jisuan() 
	{
		if (minpeijinlv.hunningtuString != "") 
		{
			switch (minpeijinlv.hunningtuString)
			{
			case"C20": 
					count.countaerfa1=1.00f; 
				break;
				
			case"C25": 
					count.countaerfa1=1.00f; 
				break;
				
			case"C30": 
					count.countaerfa1=1.00f; 
				break;
				
			case"C35": 
					count.countaerfa1=1.00f; 
				break;
				
			case"C40": 
					count.countaerfa1=1.00f; 
				break;
				
			case"C45": 
					count.countaerfa1=1.00f; 
				break;
				
			case"C50": 
					count.countaerfa1=1.00f; 
				break;
				
			case"C55": 
					count.countaerfa1=0.99f; 
				break;
				
			case"C60": 
					count.countaerfa1=0.98f; 
				break;
				
			case"C65": 
					count.countaerfa1=0.97f; 
				break;
				
			case"C70": 
					count.countaerfa1=0.96f; 
				break;
				
			case"C75": 
					count.countaerfa1=0.95f; 
				break;
				
			case"C80": 
					count.countaerfa1=0.94f; 
				break;
			}
		}
		GameObject jisuan = GameObject.Find("Jisuan/Countliangpohuaixingshi");//获得计算梁破坏形式物体
		if(jisuan!=null)
		{
			liangpohuaixingshi script = jisuan.GetComponent<liangpohuaixingshi> ();//获取计算梁破坏形式函数
			script.jisuan ();//梁破坏形式 计算
		}
		Debug.Log("阿尔法1查询结果为"+ count.countaerfa1);
	}
}
