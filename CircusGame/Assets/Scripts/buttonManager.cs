using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonManager : MonoBehaviour {

	public bool gameOver = false;

	public GameObject gameOverPanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(gameOver){
			GameOver();
		}
	}

    public void NewGameButton(string newGameScene)
    {
        SceneManager.LoadScene(newGameScene);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void GameOver() {
    	gameOverPanel.SetActive(true);
    }



}
