using UnityEngine;
using System.Collections;
public class zuixiaopeijinlv : MonoBehaviour {
    public GameObject zuixiaopeijinlvUI;
	public void jisuan() //查找最小配筋率(p min)
	{
		if (minpeijinlv.gangjinString!=""&&minpeijinlv.hunningtuString != "") 
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
			UILabel zuixiaopeijinlvlabel = zuixiaopeijinlvUI.gameObject.GetComponent<UILabel> ();
			switch (minpeijinlv.hunningtuString)
			{
			case"C20": 
			zuixiaopeijinlvlabel.text="0.200"; 
			break;
			
			case"C25": 
			zuixiaopeijinlvlabel.text="0.212"; 
			break;
			
			case"C30": 
			zuixiaopeijinlvlabel.text="0.238";
			break;
	
			case"C35": 
			zuixiaopeijinlvlabel.text="0.262"; 
			break;

			case"C40": 
			zuixiaopeijinlvlabel.text="0.285"; 
			break;

			case"C45": 
			zuixiaopeijinlvlabel.text="0.300"; 
			break;

			case"C50": 
			zuixiaopeijinlvlabel.text="0.315"; 
			break;

			case"C55": 
			zuixiaopeijinlvlabel.text="0.327"; 
			break;

			case"C60": 
			zuixiaopeijinlvlabel.text="0.340"; 
			break;

			case"C65": 
			zuixiaopeijinlvlabel.text="0.348"; 
			break;

			case"C70": 
			zuixiaopeijinlvlabel.text="0.357"; 
			break;

			case"C75": 
			zuixiaopeijinlvlabel.text="0.363"; 
			break;

			case"C80": 
			zuixiaopeijinlvlabel.text="0.370"; 
			break;
			}
			count.countzuixiaopeijinlv = float.Parse (zuixiaopeijinlvlabel.text);
		}
		Debug.Log("最小配筋率查询结果为"+ count.countzuixiaopeijinlv);
	}

	public void HRB335andHRBF335()
	{
		if (minpeijinlv.hunningtuString != "") 
		{
			UILabel zuixiaopeijinlvlabel = zuixiaopeijinlvUI.gameObject.GetComponent<UILabel> ();
			switch (minpeijinlv.hunningtuString)
			{
			case"C20": 
			zuixiaopeijinlvlabel.text="0.200"; 
			break;
			
			case"C25": 
			zuixiaopeijinlvlabel.text="0.200"; 
			break;
			
			case"C30": 
			zuixiaopeijinlvlabel.text="0.215"; 
			break;
	
			case"C35": 
			zuixiaopeijinlvlabel.text="0.236"; 
			break;

			case"C40": 
			zuixiaopeijinlvlabel.text="0.257"; 
			break;

			case"C45": 
			zuixiaopeijinlvlabel.text="0.270"; 
			break;

			case"C50": 
			zuixiaopeijinlvlabel.text="0.284"; 
			break;

			case"C55": 
			zuixiaopeijinlvlabel.text="0.294"; 
			break;

			case"C60": 
			zuixiaopeijinlvlabel.text="0.306"; 
			break;

			case"C65": 
			zuixiaopeijinlvlabel.text="0.314"; 
			break;

			case"C70": 
			zuixiaopeijinlvlabel.text="0.321"; 
			break;

			case"C75": 
			zuixiaopeijinlvlabel.text="0.327"; 
			break;

			case"C80": 
			zuixiaopeijinlvlabel.text="0.333"; 
			break;
			}
			count.countzuixiaopeijinlv = float.Parse (zuixiaopeijinlvlabel.text);
		}
		Debug.Log("最小配筋率查询结果为"+ count.countzuixiaopeijinlv);
	}

	public void HRB400andHRBF400andRRB400()
	{
		if (minpeijinlv.hunningtuString != "") 
		{
			UILabel zuixiaopeijinlvlabel = zuixiaopeijinlvUI.gameObject.GetComponent<UILabel> ();
			switch (minpeijinlv.hunningtuString)
			{
			case"C20": 
			zuixiaopeijinlvlabel.text="0.200"; 
			break;
				
			case"C25": 
			zuixiaopeijinlvlabel.text="0.200"; 
			break;
				
			case"C30": 
			zuixiaopeijinlvlabel.text="0.200"; 
			break;
				
			case"C35": 
			zuixiaopeijinlvlabel.text="0.200";
			break;
				
			case"C40": 
			zuixiaopeijinlvlabel.text="0.214"; 
			break;
				
			case"C45": 
			zuixiaopeijinlvlabel.text="0.225"; 
			break;
				
			case"C50": 
			zuixiaopeijinlvlabel.text="0.236"; 
			break;
				
			case"C55": 
			zuixiaopeijinlvlabel.text="0.245"; 
			break;
				
			case"C60": 
			zuixiaopeijinlvlabel.text="0.255"; 
			break;
				
			case"C65": 
			zuixiaopeijinlvlabel.text="0.261"; 
			break;
				
			case"C70": 
			zuixiaopeijinlvlabel.text="0.268"; 
			break;
				
			case"C75": 
			zuixiaopeijinlvlabel.text="0.273"; 
			break;
				
			case"C80": 
			zuixiaopeijinlvlabel.text="0.278"; 
			break;
			}
			count.countzuixiaopeijinlv = float.Parse (zuixiaopeijinlvlabel.text);
		}
		Debug.Log("最小配筋率查询结果为"+ count.countzuixiaopeijinlv);
	}

	public void HRB500andHRBF500()
	{
		if (minpeijinlv.hunningtuString != "") 
		{
			UILabel zuixiaopeijinlvlabel = zuixiaopeijinlvUI.gameObject.GetComponent<UILabel> ();
			switch (minpeijinlv.hunningtuString)
			{
			case"C20": 
			zuixiaopeijinlvlabel.text="0.200"; 
			break;
				
			case"C25": 
			zuixiaopeijinlvlabel.text="0.200"; 
			break;
				
			case"C30": 
			zuixiaopeijinlvlabel.text="0.200"; 
			break;
				
			case"C35": 
			zuixiaopeijinlvlabel.text="0.200"; 
			break;
				
			case"C40": 
			zuixiaopeijinlvlabel.text="0.200"; 
			break;
				
			case"C45": 
			zuixiaopeijinlvlabel.text="0.200"; 
			break;
				
			case"C50": 
			zuixiaopeijinlvlabel.text="0.200"; 
			break;
				
			case"C55": 
			zuixiaopeijinlvlabel.text="0.203"; 
			break;
				
			case"C60": 
			zuixiaopeijinlvlabel.text="0.211"; 
			break;
				
			case"C65": 
			zuixiaopeijinlvlabel.text="0.216"; 
			break;
				
			case"C70": 
			zuixiaopeijinlvlabel.text="0.221"; 
			break;
				
			case"C75": 
			zuixiaopeijinlvlabel.text="0.226"; 
			break;
				
			case"C80": 
			zuixiaopeijinlvlabel.text="0.230"; 
			break;
			}
			count.countzuixiaopeijinlv = float.Parse (zuixiaopeijinlvlabel.text);
		}
		Debug.Log("最小配筋率查询结果为"+ count.countzuixiaopeijinlv);
	}
}
