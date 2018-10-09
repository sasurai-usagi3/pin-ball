using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {
	[SerializeField]
	enum Direction {LEFT, RIGHT};

	HingeJoint hingeJoint;
	[SerializeField]
	Direction direction;

	// Use this for initialization
	void Start () {
		hingeJoint = GetComponent<HingeJoint> ();
		//rigibody.AddForce(new Vector3 (0F, 0F, 10F), ForceMode.Impulse);
		//transform.RotateAround (new Vector3 (5F, 5F, 5F), Vector3.up, 1F);
	}
	
	// Update is called once per frame
	void Update () {
		JointSpring spring = hingeJoint.spring;

		if (direction == Direction.LEFT) {
			if (Input.GetKey (KeyCode.A)) {
				spring.targetPosition = -100F;
				hingeJoint.spring = spring;
			} else {
				spring.targetPosition = 0F;
				hingeJoint.spring = spring;
			}
		} else if (direction == Direction.RIGHT) {
			if (Input.GetKey (KeyCode.L)) {
				spring.targetPosition = 100F;
				hingeJoint.spring = spring;
			} else {
				spring.targetPosition = 0F;
				hingeJoint.spring = spring;
			}
		}
	}
}
