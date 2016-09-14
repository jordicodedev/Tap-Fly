using UnityEngine;
using System.Collections;

public class MovingFloorKept : MonoBehaviour {

	//Declaro variable per incorporar GameObject (floor)
	public GameObject floor;
	
	// Use this for initialization
	void Start()
	{
		//Tenir un terra "continu"
		//Més endavant cal perfeccionar el timing i posició perquè sigui seamless (sense interrupció)
		InvokeRepeating("CreateFloor", 0.1f, 4.5f);
	}
	
	void CreateFloor()
	{
		Instantiate(floor);
	}

	void Update () {}
}
