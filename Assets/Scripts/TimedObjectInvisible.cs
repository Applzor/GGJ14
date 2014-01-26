using UnityEngine;
using System.Collections;

public class TimedObjectInvisible : MonoBehaviour {
	public float timeOut = 1.0f;

	// Use this for initialization
	void Awake () {
		Invoke ("DestroyNow", timeOut);	
	}
	
	// Update is called once per frame
	void DestroyNow () {
		renderer.enabled = false;
	}
}