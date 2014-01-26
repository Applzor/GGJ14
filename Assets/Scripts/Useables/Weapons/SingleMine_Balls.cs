using UnityEngine;
using System.Collections;

public class SingleMine_Balls : MonoBehaviour {

	public int damage = 5;

	// Use this for initialization
	void OnParticleCollision(GameObject obj) {
		if (obj.tag == "Enemy") {
			if (obj.GetComponent<EnemyAI>() != null) {
				obj.GetComponent<EnemyAI>().health -= damage;
			}
		}
	}
}