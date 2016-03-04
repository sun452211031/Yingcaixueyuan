using UnityEngine;
using System.Collections;

public class liangpohuaixingshi : MonoBehaviour {
public GameObject liangpohuaixingshiUI;
public void jisuan()
	{
		if (count.countaerfa1 != 0.0f && count.countaifuc != 0.0f && count.countaifuy != 0.0f && count.countyibusilongb != 0.0f&& count.countpeijinlv != 0.0f)
		{
			UILabel liangpohuaixingshilabel = liangpohuaixingshiUI.gameObject.GetComponent<UILabel>();

			GameObject jisuan = GameObject.Find ("Jisuan/Countjixianwanju");//获得计算极限弯矩物体
			jixianwanju script = jisuan.gameObject.GetComponent<jixianwanju>();//获得计算极限弯矩脚本

			count.countyibusilong = count.countpeijinlv*(count.countaifuy/(count.countaerfa1*count.countaifuc));//伊布斯隆计算公式
            if(count.countyibusilong<=count.countyibusilongb)//伊布斯隆 and 伊布斯隆b 对比判断
			{
				count.countliangpohuaixingshi="适筋梁";
				liangpohuaixingshilabel.text="适筋梁";
				script.jisuanshijinliang ();
			}
			else
			{
				count.countliangpohuaixingshi="超筋梁";
				liangpohuaixingshilabel.text="超筋梁";
				script.jisuanchaojinliang ();
			}
			Debug.Log("伊布斯隆 计算结果为"+ count.countyibusilong);
			Debug.Log("梁破坏形式 计算结果为"+ count.countliangpohuaixingshi);
		}
	}
}
