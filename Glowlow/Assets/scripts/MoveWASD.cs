using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWASD : MonoBehaviour {

	// Use this for initialization
	public float speed;
	public float rotSpeed;
	void Start () {
	}

	// Update is called once per frame
	void Update() {
		Vector3 temp = transform.position;
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate(Vector3.forward * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate(Vector3.back * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate(Vector3.down * Time.deltaTime * rotSpeed);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate(Vector3.up * Time.deltaTime * rotSpeed);
		}
	}
}
