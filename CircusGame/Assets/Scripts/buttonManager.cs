using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class buttonManager : MonoBehaviour {

	public bool gameOver = false;
    public bool restarted = false;

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
        Cursor.visible = true;
    	gameOverPanel.SetActive(true);
        Time.timeScale = 0.0f;
    }
    public void restart() {
        restarted = true;
        Cursor.visible = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    	gameOverPanel.SetActive(false);
    }


}
