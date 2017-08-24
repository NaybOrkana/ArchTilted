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
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		GetComponent<Rigidbody> ().velocity = Vector3.SmoothDamp (GetComponent <Rigidbody> ().velocity, movement * m_Speed, ref m_Velocity, m_Smooth);
		GetComponent<Rigidbody> ().rotation = Quaternion.Euler (GetComponent <Rigidbody>().velocity.z * m_Tilt, 0.0f, GetComponent<Rigidbody>().velocity.x * -m_Tilt);
	}

}
