using UnityEngine;
using System.Collections;

public class wanchengpanduan : MonoBehaviour {
    public GameObject dierbu;
	void Update () 
	{
	  if(kubaifangyiqi.xiapanduan>=6&&kubaifangyiqi.shangpanduan>=5)
		{ 
		   dierbu.SetActive(true);
		   gameObject.SetActive(false);
		}
	}
}
