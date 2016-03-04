using UnityEngine;
using System.Collections;

public class queding : MonoBehaviour {
	public GameObject canshu;     //参数UI
	public GameObject kaiqi;     //步骤2
	public GameObject diyibuOBJ;//步骤一物体
	
	public GameObject shiyanliang;     //实验梁
	public GameObject jializhuangzhi;  //加力装置
	public GameObject youzhizuo;   //右支座
	public GameObject zuozhizuo;   //左支座
	public GameObject youjialidian;//右加力点
	public GameObject zuojialidian;//左加力点
	public GameObject jialijia;//加力装置架子
	
	public GameObject changduUI;    //长度（L）UI
	public GameObject kuanduUI;     //宽度（b）UI
	public GameObject gaoduUI;      //高度（h）UI
	public GameObject zhizuoweizhiUI;  //支座位置（a）UI
	public GameObject jialidianweizhiUI;  //加力点位置（L1）UI
	void OnClick()
	{
	  if(count.countjixianwanju!=0.0f&&count.countkejiazaizuidazaihe!=0.0f&&count.countpeijinlv!=0.0f&&count.countzuixiaopeijinlv!=0.0f&&count.countliangpohuaixingshi!="")//确定前判定是否缺少参数
	   {
		Destroy(diyibuOBJ);//删除第一步物体
		if(shiyanliang!=null && changduUI!=null)//长度（L）上下限判断
		{
			UILabel changduLabel = changduUI.gameObject.GetComponent<UILabel>();
			if(count.countchangdu < 1400.0f)
			{
				count.countchangdu = 1400.0f;
				changduLabel.text = "1400";
			}
			if(count.countchangdu > 2800.0f)
			{
				count.countchangdu = 2800.0f;
				changduLabel.text = "2800";
			}
			
			Debug.Log("长度(L) 数值为 "+count.countchangdu);
		}
		
		if(shiyanliang!=null && kuanduUI!=null)//宽度（b）上下限判断
		{
			UILabel kuanduLabel = kuanduUI.gameObject.GetComponent<UILabel>();
			if(count.countkuandu < 100.0f)
			{
				count.countkuandu = 100.0f;
				kuanduLabel.text = "100";
			}
			if(count.countkuandu > 200.0f)
			{
				count.countkuandu = 200.0f;
				kuanduLabel.text = "200";
			}
			
			Debug.Log("宽度(b) 数值为 "+count.countkuandu);
		}
		
		if(shiyanliang!=null && gaoduUI!=null)//高度（h）上下限判断  实验梁确定
		{
			UILabel gaoduLabel = gaoduUI.gameObject.GetComponent<UILabel>();
			if(count.countgaodu < 150.0f)
			{
				count.countgaodu = 150.0f;
				gaoduLabel.text = "150";
			}
			if(count.countgaodu > 250.0f)
			{
				count.countgaodu = 250.0f;
				gaoduLabel.text = "250";
			}
			
		    shiyanliang.SetActive(true);
		    shiyanliang.transform.localScale = new Vector3(count.countkuandu/100.0f , count.countchangdu/1400.0f , count.countgaodu/150.0f);
			
		    jializhuangzhi.SetActive(true);
			jialijia.transform.localScale = new Vector3(2.18f*count.countchangdu/1400.0f , 2.18f , 2.18f);
			Debug.Log("高度(h) 数值为 "+count.countgaodu);
		}
		
		if(youzhizuo!=null && zuozhizuo!=null && zhizuoweizhiUI!=null)//支座位置（a）上下限判断  支座确定
		{
			UILabel zhizuoweizhiLabel = zhizuoweizhiUI.gameObject.GetComponent<UILabel>();
			if(count.countzhizuoweizhi < 50.0f)
			{
				count.countzhizuoweizhi = 50.0f;
				zhizuoweizhiLabel.text = "50.0";
			}
			if(count.countzhizuoweizhi > count.countchangdu/2-130.0f)
			{
				count.countzhizuoweizhi = count.countchangdu/2-130.0f;
				zhizuoweizhiLabel.text = " "+(count.countchangdu/2-130.0f);
			}
			
			youzhizuo.SetActive(true);
			zuozhizuo.SetActive(true);
			youzhizuo.transform.localPosition = new Vector3 (zuozhizuo.transform.localPosition.x-((zuozhizuo.transform.localPosition.x-youzhizuo.transform.localPosition.x)/2)-((count.countchangdu/2-count.countzhizuoweizhi)/1000.0f),youzhizuo.transform.localPosition.y,youzhizuo.transform.localPosition.z);
			zuozhizuo.transform.localPosition = new Vector3 (youzhizuo.transform.localPosition.x+(((count.countchangdu-(count.countzhizuoweizhi*2))/1000.0f)),zuozhizuo.transform.localPosition.y,zuozhizuo.transform.localPosition.z);
			Debug.Log("支座位置（a） 数值为 "+count.countzhizuoweizhi);
		}
		
		if(youjialidian!=null && zuojialidian!=null && jialidianweizhiUI!=null)//加力点位置（L1）上下限判断  加力点确定
		{
			UILabel jialidianweizhiLabel = jialidianweizhiUI.gameObject.GetComponent<UILabel>();
			if(count.countjialidianweizhi < 10.0f)
			{
				count.countjialidianweizhi = 10.0f;
				jialidianweizhiLabel.text = "10";
			}
			if(count.countjialidianweizhi > count.countchangdu/2-count.countzhizuoweizhi-50.0f)
			{
				count.countjialidianweizhi = count.countchangdu/2-count.countzhizuoweizhi-50.0f;
				jialidianweizhiLabel.text = " "+(count.countchangdu/2-count.countzhizuoweizhi-50.0f);
			}
			
			youjialidian.transform.localPosition = new Vector3 (zuojialidian.transform.localPosition.x-((zuojialidian.transform.localPosition.x-youjialidian.transform.localPosition.x)/2)-((count.countchangdu/2-count.countzhizuoweizhi-count.countjialidianweizhi)/1000.0f),youjialidian.transform.localPosition.y,youjialidian.transform.localPosition.z);
			zuojialidian.transform.localPosition = new Vector3 (youjialidian.transform.localPosition.x+(((count.countchangdu-(count.countzhizuoweizhi*2)-(count.countjialidianweizhi*2))/1000.0f)),zuojialidian.transform.localPosition.y,zuojialidian.transform.localPosition.z);
			Debug.Log("支座位置（a） 数值为 "+count.countjialidianweizhi);
		}
		
		Invoke ("quedingzhixing",2);//延迟确定
	  }
	}
	
	void quedingzhixing()
	{
	    canshu.SetActive(false);
		kaiqi.SetActive(true);
	}
}
