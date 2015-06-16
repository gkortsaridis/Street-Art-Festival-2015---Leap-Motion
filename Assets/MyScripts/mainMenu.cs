using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour {

	private int oflSizeX;
	private int oflSizeY;
	private int oflPosX;
	private int oflPosY;
	
	private int onlSizeX;
	private int onlSizeY;
	private int onlPosX;
	private int onlPosY;
	
	private int zomSizeX;
	private int zomSizeY;
	private int zomPosX;
	private int zomPosY;

	public Texture2D background;
	public Texture2D developer;

	public Texture2D sandbox_idle;
	public Texture2D sandbox_click;
	
	public Texture2D waves_idle;
	public Texture2D waves_click;

	public Texture2D letters_idle;
	public Texture2D letters_click;
	
	void Start()
	{
		oflSizeX = Screen.width / 4;
		oflSizeY = Screen.height / 10;
		oflPosX = Screen.width / 4 - oflSizeX/2;
		oflPosY = 3 * Screen.height / 4;
		
		onlSizeX = oflSizeX;
		onlSizeY = oflSizeY;
		onlPosX = Screen.width/2 - onlSizeX/2;
		onlPosY = oflPosY;
		
		zomSizeX = oflSizeX;
		zomSizeY = oflSizeY;
		zomPosX = 3*Screen.width/4 - zomSizeX/2;
		zomPosY = oflPosY;
	}
	
	public void LoadSandbox(){ Application.LoadLevel("sandbox");}
	
	public void LoadLetters(){ Application.LoadLevel("letters");}
	
	public void LoadWave(){ Application.LoadLevel("wave");}



	void OnGUI()
	{

		if(Input.GetKeyUp(KeyCode.Escape))Application.Quit();

		GUI.DrawTexture (new Rect (Screen.width - Screen.width / 5, Screen.height - Screen.height / 8, Screen.width / 5, Screen.height / 11), developer);


		GUI.skin.button.normal.background = sandbox_idle;
		GUI.skin.button.hover.background = sandbox_idle;
		GUI.skin.button.active.background = sandbox_click;
		if(GUI.Button(new Rect(oflPosX,oflPosY,oflSizeX,oflSizeY),""))Application.LoadLevel("sandbox");

		GUI.skin.button.normal.background = letters_idle;
		GUI.skin.button.hover.background = letters_idle;
		GUI.skin.button.active.background = letters_click;
		if(GUI.Button(new Rect(onlPosX,onlPosY,onlSizeX,onlSizeY),""))Application.LoadLevel("letters");

		GUI.skin.button.normal.background = waves_idle;
		GUI.skin.button.hover.background = waves_idle;
		GUI.skin.button.active.background = waves_click;
		if(GUI.Button(new Rect(zomPosX,zomPosY,zomSizeX,zomSizeY),""))Application.LoadLevel("wave");

	}

}
