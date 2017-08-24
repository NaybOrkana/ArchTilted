using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour 
{
	[Header("Unity Requirements")]
	public GameObject m_Marble;

	[Header("Gameplay Elements")]
	public Color m_NewColor;
	public GameObject m_ColorEffect;


	private void OnTriggerEnter()
	{
		// If the trigger comes into contact with the marble:
		if (m_Marble.tag == "Player") 
		{
			//It gets it's color change to the corresponding one and the proper effect is played.
			m_ColorEffect.GetComponent <Renderer>().sharedMaterial.color = m_NewColor;
			Instantiate (m_ColorEffect, transform.position, Quaternion.Euler (90f, 0f, 0f));

			m_Marble.GetComponent <Renderer>().material.color = m_NewColor;
		}
	}
}
