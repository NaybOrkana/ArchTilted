using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TiltControl : MonoBehaviour 
{
	public float m_Speed;
	public float m_Tilt;
	public float m_Smooth;

	private Vector3 m_Velocity = Vector3.zero;

	private void FixedUpdate()
	{
		//We get the controller inputs.
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		//We store them as a new vector3.
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		//We then move the rigidbody using the desired velocity and clamping it to the value of the input * the desired tilt.
		Vector3 desiredVelocity = GetComponent<Rigidbody> ().velocity = Vector3.SmoothDamp (GetComponent <Rigidbody> ().velocity, movement * m_Speed, ref m_Velocity, m_Smooth);
		GetComponent<Rigidbody> ().rotation = Quaternion.Euler (desiredVelocity.z * m_Tilt, 0.0f, desiredVelocity.x * -m_Tilt);
	}

}
