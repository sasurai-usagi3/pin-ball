using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {
	HingeJoint hingeJoint;

	// Use this for initialization
	void Start () {
		hingeJoint = GetComponent<HingeJoint> ();
		//rigibody.AddForce(new Vector3 (0F, 0F, 10F), ForceMode.Impulse);
		//transform.RotateAround (new Vector3 (5F, 5F, 5F), Vector3.up, 1F);
	}
	
	// Update is called once per frame
	void Update () {
		JointSpring spring = hingeJoint.spring;

		if (Input.GetKey (KeyCode.L)) {
			spring.targetPosition = 100F;
			hingeJoint.spring = spring;
		} else {
			spring.targetPosition = 0F;
			hingeJoint.spring = spring;
		}
	}
}
