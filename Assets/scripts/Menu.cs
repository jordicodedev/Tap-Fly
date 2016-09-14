using UnityEngine;
using System.Collections;

//NOPE
//Ignore this class-----------------vvv----------------------------------
public class Menu : MonoBehaviour {
	public Texture button_play;
	void OnGUI () {
		if (GUI.Button(new Rect(500, 160, 120, 100), button_play))
			Debug.Log("Clicked the button with an image");
			Application.LoadLevel("Play");
	}

}
//---------------------------------^^^-----------------------------------