using UnityEngine;
using System.Collections;

public class SingleShot : Useable {

	public override void Trigger() {
		particleSystem.Play ();
	}
}
