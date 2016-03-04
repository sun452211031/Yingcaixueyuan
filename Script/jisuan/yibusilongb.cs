using UnityEngine;
using System.Collections;

public class yibusilongb : MonoBehaviour {
  public void jisuan()
	{
		if (minpeijinlv.gangjinString != "" && minpeijinlv.hunningtuString != "") 
		{
			switch (minpeijinlv.gangjinString)
			{
			case"HPB300": 
					HPB300();    
				break;
			case"HRB335": 
					HRB335andHRBF335();    
				break;
			case"HRBF335": 
					HRB335andHRBF335();    
				break;
			case"HRB400": 
					HRB400andHRBF400andRRB400();    
				break;
			case"HRBF400": 
					HRB400andHRBF400andRRB400();  
				break;
			case"RRB400": 
					HRB400andHRBF400andRRB400();    
				break;
			case"HRB500": 
					HRB500andHRBF500();  
				break;
			case"HRBF500": 
					HRB500andHRBF500();    
				break;
			}
		}
	}
	public void HPB300()
	{
		if (minpeijinlv.gangjinString!=""&&minpeijinlv.hunningtuString != "") 
		{
			switch (minpeijinlv.hunningtuString)
			{
			case"C20": 
					count.countyibusilongb=0.5757f; 
				break;
				
			case"C25": 
					count.countyibusilongb=0.5757f; 
				break;
				
			case"C30": 
					count.countyibusilongb=0.5757f; 
				break;
				
			case"C35": 
					count.countyibusilongb=0.5757f;  
				break;
				
			case"C40": 
					count.countyibusilongb=0.5757f; 
				break;
				
			case"C45": 
					count.countyibusilongb=0.5757f; 
				break;
				
			case"C50": 
					count.countyibusilongb=0.5757f; 
				break;
				
			case"C55": 
					count.countyibusilongb=0.5661f; 
				break;
				
			case"C60": 
					count.countyibusilongb=0.5564f; 
				break;
				
			case"C65": 
					count.countyibusilongb=0.5468f; 
				break;
				
			case"C70": 
					count.countyibusilongb=0.5372f; 
				break;
				
			case"C75": 
					count.countyibusilongb=0.5276f; 
				break;
				
			case"C80": 
					count.countyibusilongb=0.5180f; 
				break;
			}
		}
		GameObject jisuan = GameObject.Find("Jisuan/Countliangpohuaixingshi");//获得计算梁破坏形式物体
		if(jisuan!=null)
		{
			liangpohuaixingshi script = jisuan.GetComponent<liangpohuaixingshi> ();//获取计算梁破坏形式函数
			script.jisuan ();//梁破坏形式 计算
		}
		Debug.Log("伊布斯隆b查询结果为"+ count.countyibusilongb);
	}

	public void HRB335andHRBF335()
	{
		if (minpeijinlv.gangjinString!=""&&minpeijinlv.hunningtuString != "") 
		{
			switch (minpeijinlv.hunningtuString)
			{
			case"C20": 
					count.countyibusilongb=0.5500f; 
				break;
				
			case"C25": 
					count.countyibusilongb=0.5500f;
				break;
				
			case"C30": 
					count.countyibusilongb=0.5500f;
				break;
				
			case"C35": 
					count.countyibusilongb=0.5500f; 
				break;
				
			case"C40": 
					count.countyibusilongb=0.5500f; 
				break;
				
			case"C45": 
					count.countyibusilongb=0.5500f;
				break;
				
			case"C50": 
					count.countyibusilongb=0.5500f;
				break;
				
			case"C55": 
					count.countyibusilongb=0.5405f; 
				break;
				
			case"C60": 
					count.countyibusilongb=0.5311f; 
				break;
				
			case"C65": 
					count.countyibusilongb=0.5216f; 
				break;
				
			case"C70": 
					count.countyibusilongb=0.5122f; 
				break;
				
			case"C75": 
					count.countyibusilongb=0.5027f; 
				break;
				
			case"C80": 
					count.countyibusilongb=0.4933f; 
				break;
			}
		}
		GameObject jisuan = GameObject.Find("Jisuan/Countliangpohuaixingshi");//获得计算梁破坏形式物体
		if(jisuan!=null)
		{
			liangpohuaixingshi script = jisuan.GetComponent<liangpohuaixingshi> ();//获取计算梁破坏形式函数
			script.jisuan ();//梁破坏形式 计算
		}
		Debug.Log("伊布斯隆b查询结果为"+ count.countyibusilongb);
	}

	public void HRB400andHRBF400andRRB400()
	{
		if (minpeijinlv.gangjinString!=""&&minpeijinlv.hunningtuString != "") 
		{
			switch (minpeijinlv.hunningtuString)
			{
			case"C20": 
					count.countyibusilongb=0.5176f; 
				break;
				
			case"C25": 
					count.countyibusilongb=0.5176f; 
				break;
				
			case"C30": 
					count.countyibusilongb=0.5176f; 
				break;
				
			case"C35": 
					count.countyibusilongb=0.5176f;  
				break;
				
			case"C40": 
					count.countyibusilongb=0.5176f; 
				break;
				
			case"C45": 
					count.countyibusilongb=0.5176f; 
				break;
				
			case"C50": 
					count.countyibusilongb=0.5176f; 
				break;
				
			case"C55": 
					count.countyibusilongb=0.5084f; 
				break;
				
			case"C60": 
					count.countyibusilongb=0.4992f; 
				break;
				
			case"C65": 
					count.countyibusilongb=0.4900f; 
				break;
				
			case"C70": 
					count.countyibusilongb=0.4808f; 
				break;
				
			case"C75": 
					count.countyibusilongb=0.4716f; 
				break;
				
			case"C80": 
					count.countyibusilongb=0.4625f; 
				break;
			}
		}
		GameObject jisuan = GameObject.Find("Jisuan/Countliangpohuaixingshi");//获得计算梁破坏形式物体
		if(jisuan!=null)
		{
			liangpohuaixingshi script = jisuan.GetComponent<liangpohuaixingshi> ();//获取计算梁破坏形式函数
			script.jisuan ();//梁破坏形式 计算
		}
		Debug.Log("伊布斯隆b查询结果为"+ count.countyibusilongb);
	}

	public void HRB500andHRBF500()
	{
		if (minpeijinlv.gangjinString!=""&&minpeijinlv.hunningtuString != "") 
		{
			switch (minpeijinlv.hunningtuString)
			{
			case"C20": 
					count.countyibusilongb=0.4822f; 
				break;
				
			case"C25": 
					count.countyibusilongb=0.4822f;  
				break;
				
			case"C30": 
					count.countyibusilongb=0.4822f; 
				break;
				
			case"C35": 
					count.countyibusilongb=0.4822f;  
				break;
				
			case"C40": 
					count.countyibusilongb=0.4822f; 
				break;
				
			case"C45": 
					count.countyibusilongb=0.4822f; 
				break;
				
			case"C50": 
					count.countyibusilongb=0.4822f;  
				break;
				
			case"C55": 
					count.countyibusilongb=0.4733f; 
				break;
				
			case"C60": 
					count.countyibusilongb=0.4644f; 
				break;
				
			case"C65": 
					count.countyibusilongb=0.4555f; 
				break;
				
			case"C70": 
					count.countyibusilongb=0.4466f; 
				break;
				
			case"C75": 
					count.countyibusilongb=0.4378f; 
				break;
				
			case"C80": 
					count.countyibusilongb=0.4290f; 
				break;
			}
		}
		GameObject jisuan = GameObject.Find("Jisuan/Countliangpohuaixingshi");//获得计算梁破坏形式物体
		if(jisuan!=null)
		{
			liangpohuaixingshi script = jisuan.GetComponent<liangpohuaixingshi> ();//获取计算梁破坏形式函数
			script.jisuan ();//梁破坏形式 计算
		}
		Debug.Log("伊布斯隆b查询结果为"+ count.countyibusilongb);
	}
}
