using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCatapult : MonoBehaviour
{
	[Header("Unity Requirements")]
	public Rigidbody m_Ball;
	public Transform m_Target;

	[Header("Physics Values")]
	public float m_Gravity = -9.81f;
	public float m_ArchHeight = 16f;

	[Header("Gameplay Elements")]
	public Color m_ColorForLaunch;
	public float m_DelayForLaunch = 1f;

	private void OnTriggerEnter()
	{
		//If the collision is with the marble AND the marble has the correct color; The marble gets launched with a slight delay.
		if (m_Ball.tag == "Player" && m_Ball.GetComponent <Renderer>().material.color == m_ColorForLaunch) 
		{
			Invoke ("Launch", m_DelayForLaunch);
		}
	}
	
	private void Launch()
	{
		//Gravity is equal to 1 * any gravitational value as to make many kinds of effects based on physics.
		Physics.gravity = Vector3.up * m_Gravity;

		//we then calculate the velocity it has to achieve in other to hit it's target.
		m_Ball.velocity = CalculateLaunch ();
		Debug.Log (CalculateLaunch ());
	}

	private Vector3 CalculateLaunch()
	{
		//first we get the Y distance between the marble and the target
		float displacementY = m_Target.position.y - m_Ball.position.y;
		// We then calculate the X and Z distance between the marble and the target.
		Vector3 displacementXZ = new Vector3 (m_Target.position.x - m_Ball.position.x, 0f, m_Target.position.z - m_Ball.position.z);

		//This is the formula for Upwards movement.
		Vector3 velocityY = Vector3.up * Mathf.Sqrt (-2f * m_Gravity * m_ArchHeight);

		//This is the formula for the rest of the movement.
		Vector3 velocityXZ = displacementXZ / (Mathf.Sqrt (-2f * m_ArchHeight/m_Gravity) + Mathf.Sqrt (2f * (displacementY - m_ArchHeight)/ m_Gravity));

		return velocityXZ + velocityY;
	}

}
