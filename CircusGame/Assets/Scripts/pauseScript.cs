using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class pauseScript : MonoBehaviour {

    public GameObject pauseMenuUI;

    // Use this for initialization
    void Start () {
        pauseMenuUI = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ResumePressed()
    {
        pauseMenuUI.SetActive(false);
    }
}
