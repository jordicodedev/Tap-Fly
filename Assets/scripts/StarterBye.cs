using UnityEngine;
using System.Collections;

public class StarterBye : MonoBehaviour {

	void Start () {}
	
	//Manera moooolt cutre perquè l'ocell tingui una rotació inicial mirant cap abaix
	//Xoca amb un collider just començar partida, i se'n va (el collider)
	//IMPORTANT en un futur optimitzar aquesta acció i fer-la com cal
	void Update () {
		transform.position = new Vector2 (transform.position.x-4.0f*Time.deltaTime, transform.position.y);
	}
}
