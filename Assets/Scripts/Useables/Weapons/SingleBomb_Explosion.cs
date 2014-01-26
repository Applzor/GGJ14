using UnityEngine;
using System.Collections;

public class SingleBomb_Explosion : MonoBehaviour {

	private GameObject[] targets;
	private double timer = 0;
	public int damage = 5;
	
	void Update() {
		timer += Time.deltaTime;
		Debug.Log (timer);
	}
	
	void OnTriggerStay(Collider obj) {
		if (timer >= 1) {
			if (obj.tag == "Enemy") {
				if (obj.GetComponent<EnemyAI>() != null) {
					obj.GetComponent<EnemyAI>().health -= damage;
				}
			}
			Destroy(this);
		}
	}
}
