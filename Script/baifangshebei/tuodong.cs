using UnityEngine;
using System.Collections;

public class tuodong : MonoBehaviour {
	public GameObject mainCamera;//主摄像机 
	public GameObject mainOBJ;//用于实例化物体的预制物
	
	public GameObject weizhiOBJ;//摆放的位置
	private float chushiDistan;//定义初始摆放位置和相机位置的距离数值
	
	private GameObject clone;//实例化物体
    void OnEnable()//脚本开启事件
	{
	  if(weizhiOBJ!=null)
		{
			chushiDistan = Vector3.Distance(mainCamera.transform.position,weizhiOBJ.transform.position);//初始摆放位置和相机位置的距离数值
		}
	    clone = Instantiate(mainOBJ, mainOBJ.transform.position,mainOBJ.transform.rotation)as GameObject;//实例化物体
	    if(clone!=null)
		{
			shubiaotaiqi script = clone.gameObject.GetComponent<shubiaotaiqi>();
			script.enabled=true;//实例化物体中鼠标抬起事件脚本开启，防止用于实例化物体的预制物同时被销毁
		}
	}

	void Update ()
	{
	 if(clone!=null)
	 {
	  float Distan = Vector3.Distance(mainCamera.transform.position,weizhiOBJ.transform.position);//实事计算相机和摆放位置距离
	  Vector3 worldposition = mainCamera.camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,mainCamera.camera.nearClipPlane+3.3f-((chushiDistan-Distan)/3.3f)));
	  //实例化物体在空间中的坐标，X Y坐标由点击按钮位置确定，Z坐标由相机近截面与摆放位置坐标计算确定
      clone.transform.position = worldposition;
	 }
	}
}
