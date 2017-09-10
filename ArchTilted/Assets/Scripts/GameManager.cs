using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{
	public GameObject m_LevelCompleteUI;


	public void RetryLevel()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}

	public void MenuReturn()
	{
		Debug.Log ("This will take you to the menu.");
	}

	public void LevelSelectReturn()
	{
		Debug.Log ("This will take you to level selection.");
	}

	public void LevelComplete ()
	{
		m_LevelCompleteUI.SetActive (true);
	}
}
