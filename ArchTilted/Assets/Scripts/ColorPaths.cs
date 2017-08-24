using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPaths : MonoBehaviour
{
	public Rigidbody m_Marble;
	public Color m_Color;
	public BoxCollider m_InvisibleWall;

	private bool m_SameColor = false;
	private Renderer m_Rend;

	private void Start()
	{
		m_Rend = m_Marble.GetComponent <Renderer> ();
	}

	private void Update () 
	{
		if (m_Rend.material.color == m_Color) 
		{
			m_SameColor = true;
		} 
		else 
		{
			m_SameColor = false;
		}

		if (m_SameColor == true) 
		{
			m_InvisibleWall.isTrigger = true;
		} 
		else 
		{
			m_InvisibleWall.isTrigger = false;
		}
	}
}
