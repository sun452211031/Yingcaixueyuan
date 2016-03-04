using UnityEngine;
using System.Collections;

public class weiyijitianjia : MonoBehaviour {
	public GameObject UpweiyijiGrid;//上位移计UI  Grid
	public GameObject DownweiyijiGrid;//下位移计UI  Grid
	public GameObject shiyanliang;
    void OnClick()
	{
	  if(kuweiyiji.weiyijiweizhi == "上方位移计")//上方位移计添加
	  {
		GameObject Upweiyiji = (GameObject) Instantiate(Resources.Load("Upweiyiji"));//实例物体 重置坐标
        Upweiyiji.transform.parent = UpweiyijiGrid.transform;  
		Upweiyiji.transform.localPosition = new Vector3(0,0,0);  
		Upweiyiji.transform.localScale = new Vector3(1,1,1);  
		
		UILabel UpweiyijiLabel = Upweiyiji.gameObject.GetComponent<UILabel>();//设置实例物体Label内容
		
		if(kuweiyiji.weiyijijuliName=="")//上下限 空 判断
		{
			kuweiyiji.weiyijijuliName = "0";//空
			count.countweiyijijuli = 0.0f;
		}
		count.countweiyijijuli = float.Parse(kuweiyiji.weiyijijuliName);
		if(count.countweiyijijuli > count.countchangdu/2-50)//上限
		{
			kuweiyiji.weiyijijuliName = ""+(count.countchangdu/2-50);
			count.countweiyijijuli = count.countchangdu/2-50;
		}
		if(count.countweiyijijuli < -count.countchangdu/2+50)//下限
		{
			kuweiyiji.weiyijijuliName = ""+(-count.countchangdu/2+50);
			count.countweiyijijuli = -count.countchangdu/2+50;
		}
		
		Upweiyiji.name = "Up"+kuweiyiji.weiyijiUpNUM+"and"+kuweiyiji.weiyijijuliName;//设置 实例化UI名称
		
		GameObject Up = (GameObject) Instantiate (Resources.Load ("Up"));//位移计物体实例化
		Up.transform.localPosition = new Vector3(-1.94f-(count.countweiyijijuli/1000.0f),1.78f,15.14f);
		Up.name = Upweiyiji.name;
			
		UpweiyijiLabel.text ="    Up "+kuweiyiji.weiyijiUpNUM+"                  "+kuweiyiji.weiyijijuliName+" (mm)";
		kuweiyiji.weiyijiUpNUM += 1;
		
		
		UIGrid Upscript = UpweiyijiGrid.gameObject.GetComponent<UIGrid>();//重置Gird计算
		Upscript.repositionNow = true;
		
	  }
	
	  if(kuweiyiji.weiyijiweizhi == "下方位移计")//下方位移计添加
	  {
		GameObject Downweiyiji = (GameObject) Instantiate(Resources.Load("Upweiyiji"));//实例物体 重置坐标
        Downweiyiji.transform.parent = DownweiyijiGrid.transform;  
		Downweiyiji.transform.localPosition = new Vector3(0,0,0);  
		Downweiyiji.transform.localScale = new Vector3(1,1,1);  
		
		UILabel DownweiyijiLabel = Downweiyiji.gameObject.GetComponent<UILabel>();//设置实例物体Label内容
		
		if(kuweiyiji.weiyijijuliName=="")//上下限 空 判断
		{
			kuweiyiji.weiyijijuliName = "0";//空
			count.countweiyijijuli = 0.0f;
		}
		count.countweiyijijuli = float.Parse(kuweiyiji.weiyijijuliName);
		if(count.countweiyijijuli > count.countchangdu/2-50)//上限
		{
			kuweiyiji.weiyijijuliName = ""+(count.countchangdu/2-50);
			count.countweiyijijuli = count.countchangdu/2-50;
		}
		if(count.countweiyijijuli < -count.countchangdu/2+50)//下限
		{
			kuweiyiji.weiyijijuliName = ""+(-count.countchangdu/2+50);
			count.countweiyijijuli = -count.countchangdu/2+50;
		}
		
		Downweiyiji.name = "Down"+kuweiyiji.weiyijiDownNUM+"and"+kuweiyiji.weiyijijuliName;//设置 实例化UI名称
		
		GameObject Down = (GameObject) Instantiate (Resources.Load ("Down"));//位移计物体实例化
		Down.transform.localPosition = new Vector3(-1.94f-(count.countweiyijijuli/1000.0f),1.34f,15.14f);
		Down.name = Downweiyiji.name;
			
		DownweiyijiLabel.text ="  Down "+kuweiyiji.weiyijiDownNUM+"                  "+kuweiyiji.weiyijijuliName+" (mm)";
		kuweiyiji.weiyijiDownNUM += 1;
		
		
		UIGrid Downscript = DownweiyijiGrid.gameObject.GetComponent<UIGrid>();//重置Gird计算
		Downscript.repositionNow = true;
	  }
	}
}
