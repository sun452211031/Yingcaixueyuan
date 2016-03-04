using UnityEngine;
using System.Collections;

public class juli : MonoBehaviour {
  public void jisuan()
	{
		UILabel juliLabel = gameObject.GetComponent<UILabel>();
		kuweiyiji.weiyijijuliName = juliLabel.text;
		
		Debug.Log ("位移计 名为"+kuweiyiji.weiyijijuliName);
	}
}
