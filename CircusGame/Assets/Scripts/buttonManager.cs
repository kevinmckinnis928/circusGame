﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void NewGameButton(string newGameScene)
    {
        SceneManager.LoadScene(newGameScene);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    
}
