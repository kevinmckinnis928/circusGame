using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class buttonManager : MonoBehaviour {

	public bool gameOver = false;
    public bool restarted = false;

    public GameObject gameOverPanel;
    public GameObject scorePanel;

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
        Time.timeScale = 0.0f;
        scorePanel.SetActive(false);
    	gameOverPanel.SetActive(true);
        
    }
    public void restart() {
        restarted = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    	gameOverPanel.SetActive(false);
    }


}
