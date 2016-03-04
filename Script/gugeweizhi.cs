using UnityEngine;
using System.Collections;

public class gugeweizhi : MonoBehaviour {

	public Transform weizhi;
	void Start()
	{
		Invoke("xiaohui",2);
	}
	
	void Update() 
	{
	 if(weizhi!=null)
	 {
	   transform.position = weizhi.transform.position;
	 }
	}
	
	void xiaohui()
	{
		Destroy(GetComponent("gugeweizhi"));
	}
}
