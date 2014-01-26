using UnityEngine;
using System.Collections;

public class PickupObject : MonoBehaviour {

	public Vector3 heldOffset = Vector3.zero;

	void OnTriggerStay(Collider e) {
				
		if (e.tag == "Player") {
			if (Input.GetButtonDown("Fire2")) {
				//	Stop animation
				transform.GetComponentInChildren<Animator>().SetInteger("pickup", 1);

				//	Remove any objects already attached to the player
				foreach (Transform child in e.transform) {
					Destroy(child.gameObject);
				}

				//	Get a random weapon/ability and attach to the object
				GameObject[] useables = GameObject.Find("$GameManager").GetComponent<GameManager>().useables;
				int i = Random.Range(0,useables.Length);
				GameObject useable = Instantiate(useables[i], transform.position + (transform.forward*1), transform.rotation) as GameObject;
				useable.transform.parent = transform;

				//	attach object to the collider (player) at an offset
				transform.position = e.transform.position + (e.transform.forward);
				transform.rotation = e.transform.rotation;
				transform.parent = e.transform;
			}
		}
	}
}
