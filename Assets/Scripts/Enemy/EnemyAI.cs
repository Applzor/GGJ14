using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	public int health = 10;

	void FixedUpdate() {
		if (health <= 0) {
			Die();
		}
	}

	void Die() {
		Destroy (this.gameObject);
	}
}
