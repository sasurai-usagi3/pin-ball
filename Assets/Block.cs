using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {
	Renderer renderer;

	// Use this for initialization
	void Start () {
		int colorIndex = Random.Range (0, 3);
		string[] materialNames = new string[]{ "BlockRed", "BlockBlue", "BlockGreen" };

		renderer = GetComponent<Renderer> ();
		renderer.material = Resources.Load (materialNames [colorIndex]) as Material;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.collider.tag != "Ball") {
			return;
		}

		Point.instantce.value += 10;

		print (Point.instantce.value); // NOTE: for debug.

		Destroy (this.gameObject);
	}
}
