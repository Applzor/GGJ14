using UnityEngine;
using System.Collections;

public class Useable : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public virtual void Trigger() {
		Debug.Log ("You used this useable!");
	}
}
