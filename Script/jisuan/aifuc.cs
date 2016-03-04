using UnityEngine;
using System.Collections;

public class aifuc : MonoBehaviour {
  public void jisuan()
	{
		if (minpeijinlv.hunningtuString != "") 
		{
			switch (minpeijinlv.hunningtuString)
			{
			case"C20": 
					count.countaifuc=9.6f; 
				break;
				
			case"C25": 
					count.countaifuc=11.9f;
				break;
				
			case"C30": 
					count.countaifuc=14.3f;
				break;
				
			case"C35": 
					count.countaifuc=16.7f;
				break;
				
			case"C40": 
					count.countaifuc=19.1f;
				break;
				
			case"C45": 
					count.countaifuc=21.1f;
				break;
				
			case"C50": 
					count.countaifuc=23.1f; 
				break;
				
			case"C55": 
					count.countaifuc=25.3f;
				break;
				
			case"C60": 
					count.countaifuc=27.5f;
				break;
				
			case"C65": 
					count.countaifuc=29.7f;
				break;
				
			case"C70": 
					count.countaifuc=31.8f; 
				break;
				
			case"C75": 
					count.countaifuc=33.8f;
				break;
				
			case"C80": 
					count.countaifuc=35.9f;
				break;
			}
		}
		GameObject jisuan = GameObject.Find("Jisuan/Countliangpohuaixingshi");//获得计算梁破坏形式物体
		if(jisuan!=null)
		{
			liangpohuaixingshi script = jisuan.GetComponent<liangpohuaixingshi> ();//获取计算梁破坏形式函数
			script.jisuan ();//梁破坏形式 计算
		}
		Debug.Log("Fc 查询结果为"+ count.countaifuc);
	}
}
