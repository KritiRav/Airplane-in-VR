using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = Camera.main.transform.forward;
		float scalor = 1f + Time.deltaTime;
		transform.Translate (direction * scalor);
	}
}
