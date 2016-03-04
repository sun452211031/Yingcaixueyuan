using UnityEngine;
using System.Collections;

public class weiyijiqueding : MonoBehaviour {
public GameObject guanbi;
public GameObject kaiqi;
	void OnClick()
	{
		kaiqi.SetActive(true);
		guanbi.SetActive(false);
	}
}
