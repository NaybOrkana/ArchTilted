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
		Vector3 desiredPosition = m_Target.position + m_Offset;

		transform.LookAt (m_Target);
		transform.position = Vector3.SmoothDamp (transform.position, desiredPosition, ref m_Velocity, m_Smoothing);

	}
}
