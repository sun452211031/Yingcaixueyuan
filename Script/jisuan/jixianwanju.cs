using UnityEngine;
using System.Collections;

public class jixianwanju : MonoBehaviour {
	public GameObject jixianwanjuUI;
	public GameObject kejiazaizuidazaiheUI;
    public void jisuanshijinliang()//适筋梁极限弯矩计算
	{
		if (count.countliangpohuaixingshi != "")
		{
			count.countjixianwanju = count.countaerfa1 * count.countaifuc * count.countkuandu * (count.countho * count.countho) * count.countyibusilongb * (1 - (count.countyibusilongb / 2))/1000000.0f;
			//适筋梁极限弯矩 计算公式
			UIInput jixianwanjuInput = jixianwanjuUI.gameObject.GetComponent<UIInput>();
			jixianwanjuInput.value = ""+count.countjixianwanju;
			kejiazaizuidazaihe();

			Debug.Log("适筋梁极限弯矩 计算结果为"+ count.countjixianwanju);
		}
	}
	public void jisuanchaojinliang()//超筋梁极限弯矩计算
    {
		if (count.countliangpohuaixingshi != "")
		{
			count.countjixianwanju = count.countaerfa1 * count.countaifuc * count.countkuandu * (count.countho * count.countho) * count.countyibusilongb * (1 - (count.countyibusilongb / 2))/1000000.0f;
			//count.countjixianwanju = count.countaerfa1 * count.countaifuc * count.countkuandu * count.countx * (count.countho - (count.countx / 2))/1000000.0f;
			//超筋梁极限弯矩 计算公式 因无法确定countx 固按适筋梁计算
			UIInput jixianwanjuInput = jixianwanjuUI.gameObject.GetComponent<UIInput>();
			jixianwanjuInput.value = ""+count.countjixianwanju;
			kejiazaizuidazaihe();

			Debug.Log("超筋梁极限弯矩 计算结果为"+ count.countjixianwanju);
		}
    }

	public void kejiazaizuidazaihe()//可加载最大载荷计算
	{
		if (count.countliangpohuaixingshi != "" && count.countjialidianweizhi != 0.0f)
	    {
		    count.countkejiazaizuidazaihe = count.countjixianwanju / (count.countjialidianweizhi/1000.0f);
			//可加载最大载荷 计算公式
			UIInput kejiazaizuidazaiheInput = kejiazaizuidazaiheUI.gameObject.GetComponent<UIInput>();
			kejiazaizuidazaiheInput.value = ""+count.countkejiazaizuidazaihe;

			Debug.Log("可加载最大载荷 计算结果为"+ count.countkejiazaizuidazaihe);
	    }
	}

}
