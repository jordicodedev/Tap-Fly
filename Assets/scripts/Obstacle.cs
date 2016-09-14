using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	public float range = 9;
	// Use this for initialization
	void Start(){
		//Randomizer de posicions on apareixen els obstacles
		transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		//Velocitat obstacle -4
		transform.position = new Vector2 (transform.position.x-4.0f*Time.deltaTime, transform.position.y);

	}


}
