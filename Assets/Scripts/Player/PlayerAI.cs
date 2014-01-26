using UnityEngine;
using System.Collections;

public class PlayerAI : MonoBehaviour {

	public int health = 100;
	public GameObject particle;

	void OnTriggerEnter(Collider e) {
		if (e.tag == "bullet") {
			health -= 2;
			Destroy (e.gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			for (float i = 0; i < 10; i++) {
				Invoke("Die", i);
			}
			Invoke ("Restart", 5);
		}
	}

	void Die() {
		Instantiate (particle, transform.position, transform.rotation);
	}

	void Restart() {
		Application.LoadLevel(Application.loadedLevel);
	}
}
