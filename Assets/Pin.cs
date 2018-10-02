using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {
	Rigidbody rigibody;

	// Use this for initialization
	void Start () {
		rigibody = GetComponent<Rigidbody> ();
		//rigibody.AddForce(new Vector3 (0F, 0F, 10F), ForceMode.Impulse);
		//transform.RotateAround (new Vector3 (5F, 5F, 5F), Vector3.up, 1F);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
