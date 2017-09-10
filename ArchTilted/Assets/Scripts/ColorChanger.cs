using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour 
{
	[Header("Unity Requirements")]
	public GameObject m_Marble;

	[Header("Gameplay Elements")]
	public Color m_NewColor;
	public GameObject m_CenterRingS;
	public GameObject m_CenterRingL;
	public GameObject m_CenterColor;

	private Material materialColored;

	private void Start()
	{
		materialColored = new Material (Shader.Find ("Standard"));
		materialColored.color = m_NewColor;

		m_CenterRingS.GetComponent <Renderer> ().material = materialColored;
		m_CenterRingL.GetComponent <Renderer>().material = materialColored;
		m_CenterColor.GetComponent <Renderer> ().material = materialColored;

	}


	private void OnTriggerEnter()
	{
		// If the trigger comes into contact with the marble:
		if (m_Marble.tag == "Player") 
		{
			ColorChange ();
		}
	}

	private void ColorChange()
	{
		m_Marble.GetComponent <Renderer>().material.color = m_NewColor;
	}
}
