using UnityEngine;
using System.Collections;

public class goBack : MonoBehaviour {

	public Texture2D developer;

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.Escape))Application.LoadLevel("MainMenu");
	}

	void OnGUI(){
		GUI.DrawTexture (new Rect (Screen.width - Screen.width / 5, Screen.height - Screen.height / 8, Screen.width / 5, Screen.height / 11), developer);

	}
}
