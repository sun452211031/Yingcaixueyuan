using UnityEngine;
using System.Collections;

public class xiala : MonoBehaviour {
	public GameObject beijing;
	void OnClick()//下拉框
	{
		if (beijing.activeSelf == false&&canshu.canshuUIstate==true) 
		{
			canshu.canshuUIstate=false;
			beijing.SetActive (true);
		}
	
	}
}
