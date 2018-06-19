using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldScript : MonoBehaviour {

	public int playerLives = 3;
	public int playerPoints = 0;

	 [SerializeField] private GameObject pausePanel;

	// Use this for initialization
	void Start () {
		pausePanel.SetActive(false);
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.Escape))
		{
			if (!pausePanel.activeInHierarchy)
			{
					PauseGame();
			}
			if (pausePanel.activeInHierarchy)
			{
					 ContinueGame();
			}
		}
	}
	private void PauseGame()
	{
		Time.timeScale = 0;
		pausePanel.SetActive(true);
		//Disable scripts that still work while timescale is set to 0
	}
	private void ContinueGame()
	{
			Time.timeScale = 1;
			pausePanel.SetActive(false);
			//enable the scripts again
	}
}
