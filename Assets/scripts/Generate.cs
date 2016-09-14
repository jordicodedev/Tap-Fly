using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {
	//el GameObject es linkeja a l'apartat visual de Unity
	public GameObject boxes;
	
	void Start()
	{
		//Repetició de crear obstacle caixes(boxes)
		InvokeRepeating("CreateObstacle", 1f, 1.5f);
	}
	
	void CreateObstacle()
	{
		Instantiate(boxes);
	}

	void Update () {}
}
