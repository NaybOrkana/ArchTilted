using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMechanism : MonoBehaviour 
{
	[Header("Unity Requirements")]
	public GameObject m_Marble;
	public GameObject m_Wall;

	[Header("Gameplay Elements")]
	public Color m_CorrectColor;
	public float m_SlideTime = 1f;
	private bool m_OpenPath = false;


	private void OnTriggerEnter()
	{

		if (m_Marble.tag == "Player" && m_Marble.GetComponent <Renderer>().material.color == m_CorrectColor) 
		{
			m_OpenPath = true;
		}
	}

	private void Update ()
	{
		if (m_OpenPath == true) 
		{
			WallMovement ();
			m_OpenPath = false;
		}
	}

	private void WallMovement()
	{
		m_Wall.GetComponent <BoxCollider>().enabled = false;
		float desiredPosition = Mathf.Lerp (m_Wall.transform.position.y, -m_Wall.transform.position.y, m_SlideTime);

		m_Wall.transform.position = new Vector3 (m_Wall.transform.position.x, desiredPosition, m_Wall.transform.position.z);
	}
}
