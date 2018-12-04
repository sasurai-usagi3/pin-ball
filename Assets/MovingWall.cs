using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWall : MonoBehaviour {
	Rigidbody rigidbody;
	Vector3 delta;

	// Use this for initialization
	void Start () {
		delta = Vector3.left / 50;
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.x < -1.8 || 1.6 < transform.position.x) {
			delta = -delta;
		}

		transform.position += delta;
	}
}
