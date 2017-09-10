using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour 
{
	public GameObject m_PausedUI;
	public GameManager m_Manager;

	private void Update()
	{
		if (Input.GetKeyDown (KeyCode.P) || Input.GetKeyDown (KeyCode.Escape)) 
		{
			TogglePause ();
		}
	}

	public void TogglePause()
	{
		m_PausedUI.SetActive (!m_PausedUI.activeSelf);

		if (m_PausedUI.activeSelf) 
		{
			Time.timeScale = 0f;
		} else 
		{
			Time.timeScale = 1f;
		}
	}

	public void RetryButton()
	{
		TogglePause ();

		m_Manager.RetryLevel ();
	}

	public void MenuButton()
	{
		m_Manager.MenuReturn ();
	}


	public void SelectLevelButton()
	{
		m_Manager.LevelSelectReturn ();
	}
}
