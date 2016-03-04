using UnityEngine;
using System.Collections;

public class buzhou : MonoBehaviour {
public GameObject kaiqi;
	void OnClick()
	{
		kaiqi.SetActive(true);
		gameObject.SetActive(false);
	}
}
