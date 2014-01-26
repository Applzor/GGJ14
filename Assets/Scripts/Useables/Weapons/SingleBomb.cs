using UnityEngine;
using System.Collections;

public class SingleBomb : Useable {

	public GameObject[] particles;

	public override void Trigger() {

		Plane plane = new Plane (Vector3.up, transform.position);
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		float hitDist = 0.0f;

		if (plane.Raycast(ray, out hitDist)) {
			Vector3 target = ray.GetPoint(hitDist);
			foreach (GameObject obj in particles) {
				Instantiate(obj, target, transform.rotation);
			}
		}


	}
}
