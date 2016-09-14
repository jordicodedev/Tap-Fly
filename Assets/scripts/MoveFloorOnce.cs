using UnityEngine;
using System.Collections;

public class MoveFloorOnce : MonoBehaviour {

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
		//Es mou el terra cap a l'esquerre a la mateixa velocitat que els obstacles
		transform.position = new Vector2 (transform.position.x-4.0f*Time.deltaTime, transform.position.y);
	}
}
