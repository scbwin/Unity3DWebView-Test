using UnityEngine;
using System.Collections;

public class testview : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		WebViewObject.sInstance.Init((msg)=>{
			Debug.Log(string.Format("CallFromJS[{0}]", msg));
		});
		
		WebViewObject.sInstance.SetMargins(5, 5, 5, 40);
		WebViewObject.sInstance.SetVisibility(true);
		string path = "file://" + Application.dataPath + "/Scripts/core/sample.html";
		Debug.Log(path);
		WebViewObject.sInstance.LoadURL(path);

		// WebViewObject webViewObject =
		// 	(new GameObject("WebViewObject")).AddComponent<WebViewObject>();
		// webViewObject.Init((msg)=>{
		// 	Debug.Log(string.Format("CallFromJS[{0}]", msg));
		// 	// status.text = msg;
		// 	// status.animation.Play();
		// });
		
		// webViewObject.SetMargins(5, 5, 5, 40);
		// webViewObject.SetVisibility(true);
		// string path = "file://" + Application.dataPath + "/Scripts/core/sample.html";
		// webViewObject.LoadURL(path);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
