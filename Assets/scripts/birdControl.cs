using UnityEngine;
using System.Collections;

public class birdControl : MonoBehaviour {

	public AudioClip Flap;
	public AudioClip Hit;
	public Vector2 birdUp = new Vector2(0, 300);

	void Start (){}
	
	// Update is called once per frame
	void Update () {
		//Jump -> space or up arrow key
		if (Input.GetKeyUp("space") || Input.GetKeyUp("up"))
		{
			Debug.Log ("I jump");
			//Play sound on every tap/flap
			AudioSource.PlayClipAtPoint(Flap, transform.position);  
			//Velocity is set to zero
			rigidbody2D.velocity = Vector2.zero;
			//Add force to y axis
			rigidbody2D.AddForce(birdUp);

			//Sets bird to 0º on every tap
			//Bird does flappy-like effect at start thanks to class StarterBye (see script)
			transform.rotation = Quaternion.Euler(0, 0, 0);
		}
	}
	//Bird hits a trigger object (boxes or floor) A.K.A FAIL
	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("Trigger object");
		//Play hit sound
		AudioSource.PlayClipAtPoint(Hit, transform.position);  
		//És necessari un delay to play hit sound complet/semi-complet
		Invoke( "RestartLevel", 0.1f );
	}

	void RestartLevel() {
		//Més endevant cal introduir main menú
		//Application.LoadLevel("MainMenu");
		Application.LoadLevel("Play");  
	}
	
}
