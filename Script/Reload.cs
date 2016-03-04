using UnityEngine;
using System.Collections;

public class Reload : MonoBehaviour {
  void OnClick()
	{
		canshu.canshuUIstate = true;
		
		minpeijinlv.gangjinString = "";
		minpeijinlv.gangjinString = "";
		
		kugangjinzhijing.kugangjinzhijingString = "";
		
		kuweiyiji.xialastate = true;
		kuweiyiji.weiyijiUpNUM = 1;
		kuweiyiji.weiyijiDownNUM = 1;
		kuweiyiji.weiyijiweizhi = "";
		kuweiyiji.weiyijijuliName = "";
		kuweiyiji.weiyijishanchu = "";
		
		kubaifangyiqi.shangpanduan = 1;
		kubaifangyiqi.xiapanduan = 1;
		kubaifangyiqi.presspanduan = true;
		kubaifangyiqi.enterpanduan = false;
		
		count.countliangpohuaixingshi="";
		count.countchangdu=0.0f;
	    count.countzhizuoweizhi=0.0f;
	    count.countjialidianweizhi=0.0f;
	    count.countkuandu=0.0f;
	    count.countgaodu=0.0f;
	    count.countgangjingenshu=0.0f;
	    count.countbaohucenghoudu=0.0f;
	    count.countzuixiaopeijinlv=0.0f;
	    count.countgangjinzhijing = 0.0f;
	    count.countpeijinlv = 0.0f;
	    count.countyibusilongb = 0.0f;
	    count.countyibusilong = 0.0f;
	    count.countaerfa1 = 0.0f;
	    count.countaifuc = 0.0f;
	    count.countaifuy = 0.0f;
	    count.countho = 0.0f;
	    count.countjixianwanju = 0.0f;
	    count.countkejiazaizuidazaihe = 0.0f;
        count.countx = 1.0f;  
	    count.countweiyijijuli = 0.0f;
		count.countdangqianhezai = 0.0f;
		//重置canshuku数据
		Application.LoadLevel("shiyanchangjing");
	}
}
