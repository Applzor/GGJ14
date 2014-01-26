using UnityEngine;
using System.Collections;

public class Trigger_Useable : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.parent) {
			if (Input.GetButtonDown("Fire1") && transform.parent.tag == "Player") {
				foreach (Transform child in transform) {
					if (child.GetComponent<Useable>() != null)
						child.GetComponent<Useable>().Trigger();
				}
			}
		}
	}
}
