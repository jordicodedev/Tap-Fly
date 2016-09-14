using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {
	//int score
	int score = 0;
	public AudioClip Score;
	void Start () {}
	void Update () {}
	//Graphical User Interface - Genera un label a la part superior de la pantalla on mostra el Score: +scorepoint
	void OnGUI () 
	{
		GUI.color = Color.black;
		GUILayout.Label(" Score: " + score.ToString());
	}
	//Es suma el score quan es destrueix un objecte (en aquest cas el floor i les caixes)
	void OnTriggerEnter2D(Collider2D other)
	{
		Destroy (other.gameObject);
		score++;
		//Play score sound
		AudioSource.PlayClipAtPoint(Score, transform.position);  
	}
}
