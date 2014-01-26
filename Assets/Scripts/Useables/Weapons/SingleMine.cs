using UnityEngine;
using System.Collections;

public class SingleMine : Useable {

	public GameObject[] particles;

	public override void Trigger() {

		foreach (GameObject obj in particles) 
			Instantiate(obj, transform.position + (transform.up*0.25f), Quaternion.Euler(-90,0,0));
	}
}
