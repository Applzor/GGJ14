using UnityEngine;
using System.Collections;

public class SingleShot : Useable {

	public int damage = 5;
	public GameObject particle;
	private GameObject obj;
	private double timer = 0; 

	void Start() {
		//obj = Instantiate (particle, new Vector3 (0, 100, 0), Quaternion.Euler(0,0,0)) as GameObject;
	}

	void Update() {
		timer += Time.deltaTime;
		//if (timer >= 1) {
		//	obj.renderer.enabled = false;
		//}
	}

	public override void Trigger() {
		particleSystem.Play ();
		//obj.transform.position = transform.position + (transform.forward * 2);
		//obj.rigidbody.AddForce (transform.up * 100);
		timer = 0;
	}

	// Use this for initialization
	void OnParticleCollision(GameObject obj) {
		if (obj.tag == "Enemy") {
			if (obj.GetComponent<EnemyAI>() != null) {
				obj.GetComponent<EnemyAI>().health -= damage;
			}
		}
	}
}
