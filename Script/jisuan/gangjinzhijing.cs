using UnityEngine;
using System.Collections;

public class gangjinzhijing: MonoBehaviour {
  public void jisuan()
	{
		if (kugangjinzhijing.kugangjinzhijingString != "") 
		{
			switch(kugangjinzhijing.kugangjinzhijingString)
			{
			case"D10":
			count.countgangjinzhijing=10.0f;
			break;
			
			case"D12":
					count.countgangjinzhijing=12.0f;
				break;

			case"D14":
					count.countgangjinzhijing=14.0f;
				break;

			case"D16":
					count.countgangjinzhijing=16.0f;
				break;

			case"D18":
					count.countgangjinzhijing=18.0f;
				break;

			case"D20":
					count.countgangjinzhijing=20.0f;
				break;

			case"D22":
					count.countgangjinzhijing=22.0f;
				break;

			case"D24":
					count.countgangjinzhijing=24.0f;
				break;

			case"D26":
					count.countgangjinzhijing=26.0f;
				break;

			case"D28":
					count.countgangjinzhijing=28.0f;
				break;

			case"D30":
					count.countgangjinzhijing=30.0f;
				break;

			case"D32":
					count.countgangjinzhijing=32.0f;
				break;

			case"D34":
					count.countgangjinzhijing=34.0f;
				break;

			case"D36":
					count.countgangjinzhijing=36.0f;
				break;

			case"D38":
					count.countgangjinzhijing=38.0f;
				break;

			case"D40":
					count.countgangjinzhijing=40.0f;
				break;
			}
			GameObject Countpeijinlv = GameObject.Find("Jisuan/Countpeijinlv");//计算配筋率物体
			peijinlv script = Countpeijinlv.GetComponent<peijinlv> ();
			script.jisuan ();
		}
		Debug.Log("钢筋直径为"+ count.countgangjinzhijing);
	}
}
