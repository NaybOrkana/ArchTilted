using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	[Header("Object to Follow")]
	public Transform m_Target;

	[Header("Adjustments")]
	public Vector3 m_Offset;
	public float m_Smoothing = 0.3f;

	private Vector3 m_Velocity = Vector3.zero;

	private void LateUpdate () 
	{
		//We offset the position off the camera with a new vector3 
		Vector3 desiredPosition = m_Target.position + m_Offset;

		//We rotate the camera to always look at it's target.
		transform.LookAt (m_Target);

		//We smooth out the movement of the camera to avoid jitter.
		transform.position = Vector3.SmoothDamp (transform.position, desiredPosition, ref m_Velocity, m_Smoothing);

	}
}
