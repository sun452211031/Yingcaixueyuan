using UnityEngine;
using System.Collections;

public class weiyijishanchu : MonoBehaviour {
    public GameObject UpweiyijiGrid;//上位移计UI  Grid
	public GameObject DownweiyijiGrid;//下位移计UI  Grid
	void OnClick()
	{
		GameObject UpweiyijiUI = GameObject.Find ("UI Root/Camera/Weiyiji/Upliebiao/Scroll View/UpGrid/"+kuweiyiji.weiyijishanchu);
		GameObject DownweiyijiUI = GameObject.Find ("UI Root/Camera/Weiyiji/Downliebiao/Scroll View/DownGrid/"+kuweiyiji.weiyijishanchu);
	    GameObject weiyiOBJ = GameObject.Find ("/"+kuweiyiji.weiyijishanchu);
 	
		if(UpweiyijiUI!=null && weiyiOBJ!=null)
		{
			Destroy (UpweiyijiUI);
			Destroy (weiyiOBJ);
			
			UIGrid Upscript = UpweiyijiGrid.gameObject.GetComponent<UIGrid>();//重置Gird计算
		    Upscript.repositionNow = true;
		}
		
		if(DownweiyijiUI!=null && weiyiOBJ!=null)
		{
			Destroy (DownweiyijiUI);
			Destroy (weiyiOBJ);
			
			UIGrid Downscript = DownweiyijiGrid.gameObject.GetComponent<UIGrid>();//重置Gird计算
		    Downscript.repositionNow = true;
		}

	}
}
