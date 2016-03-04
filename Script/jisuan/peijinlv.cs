using UnityEngine;
using System.Collections;

public class peijinlv : MonoBehaviour {
	public GameObject peijinlvUI;
	public void jisuan() //配筋率（p）计算
	{
		if (count.countgaodu != 0.0f && count.countkuandu != 0.0f && count.countgangjinzhijing != 0.0f&&count.countgangjingenshu!=0.0f&&count.countbaohucenghoudu!=0.0f)
		{
			float As = Mathf.PI*(count.countgangjinzhijing/2)*(count.countgangjinzhijing/2);//公式
			count.countho = count.countgaodu-15.0f-count.countbaohucenghoudu;//公式
			count.countpeijinlv = (As*count.countgangjingenshu)/(count.countkuandu*count.countho);//公式
			UIInput peijinlvInput = peijinlvUI.gameObject.GetComponent<UIInput>();
			peijinlvInput.value=""+count.countpeijinlv;

			GameObject jisuan = GameObject.Find("Jisuan/Countliangpohuaixingshi");//获得计算梁破坏形式物体
			if(jisuan!=null)
			{
				liangpohuaixingshi script = jisuan.GetComponent<liangpohuaixingshi> ();//获取计算梁破坏形式函数
				script.jisuan ();//梁破坏形式 计算
			}

			Debug.Log("ho 数值为 "+count.countho);
			Debug.Log("配筋率（p）数值为 "+count.countpeijinlv);
		}
	}

}
