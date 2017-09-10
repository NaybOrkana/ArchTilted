using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed;

	public GameObject Mycamera;

	void FixedUpdate()
	{
		float movementHorizontal = Input.GetAxis("Horizontal");
		float movementVertical = Input.GetAxis("Vertical");

		Vector3 movementVector = new Vector3(movementHorizontal, 0.0f, movementVertical);
		movementVector = Mycamera.transform.TransformDirection(movementVector);

		GetComponent<Rigidbody>().AddForce(movementVector * speed * Time.deltaTime);
	}
}
