using UnityEngine;
using System.Collections;

public class tianjiali : MonoBehaviour {
	public GameObject zuidahezai;//最大荷载UI
	public GameObject dangqianhezai;//当前荷载UI
	public GameObject dangqianhezaizhizhen;//当前荷载指针
	public GameObject weiyijizhizhen;//位移计指针
	public GameObject yingbianpianzhedang;//应变片遮挡
	private bool panduan = false;//鼠标按下抬起状态
	void Start () 
	{
	  UIInput zuidahezaiInput = zuidahezai.GetComponent<UIInput>(); //获取可加载最大载荷并且显示
	  zuidahezaiInput.value = ""+count.countkejiazaizuidazaihe;
	}
	
	void Update ()
	{
	  if(panduan==true&&count.countdangqianhezai<=count.countkejiazaizuidazaihe)//鼠标按下和上限判断
		{
	     count.countdangqianhezai += 0.1f*count.countkejiazaizuidazaihe*Time.deltaTime;
	     UIInput dangqianhezaiInput = dangqianhezai.GetComponent<UIInput>();
	     dangqianhezaiInput.value = ""+count.countdangqianhezai;
		}
	
	  dangqianhezaizhizhen.transform.eulerAngles = new Vector3(0,0,-(180.0f*(count.countdangqianhezai/count.countkejiazaizuidazaihe)));
	  weiyijizhizhen.transform.eulerAngles = new Vector3(0,0,-(180.0f*(count.countdangqianhezai/count.countkejiazaizuidazaihe)/2+55.3f));
	  yingbianpianzhedang.transform.localScale = new Vector3(1-(count.countdangqianhezai/count.countkejiazaizuidazaihe),1,1);
	}
	void OnPress() 
	{
		panduan = true;
		if(Input.GetMouseButtonUp(0)||Input.GetMouseButtonUp(1)||Input.GetMouseButtonUp(2))
		{
			panduan = false;
		}
	}
}
