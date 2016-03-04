using UnityEngine;
using System.Collections;

public class buzhou1 : MonoBehaviour {
public GameObject kaiqi;
public GameObject kaiqi1;
public GameObject kaiqi2;
	void OnClick()
	{
		kaiqi.SetActive(true);
		kaiqi1.SetActive(true);
		kaiqi2.SetActive(true);
		gameObject.SetActive(false);
	}
}
