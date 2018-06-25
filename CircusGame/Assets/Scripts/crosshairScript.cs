using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.Gaming;

public class crosshairScript : MonoBehaviour {


	 public int playerLives = 3;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 screenPoint = TobiiAPI.GetGazePoint().Screen;
        screenPoint.z = 1f;
        this.transform.position = Camera.main.ScreenToWorldPoint(screenPoint);

        // if(!GameObject.Find("PauseMenu").GetComponent<pauseMenu>().gamePaused) 
        // {
        //Vector3 temp = Input.mousePosition;
        //temp.z = 10f; // Set this to be the distance you want the object to be placed in front of the camera.
        //this.transform.position = Camera.main.ScreenToWorldPoint(temp);
        // }
    }

	void OnTriggerEnter2D(Collider2D other){

	}
	void OnTriggerStay2D(Collider2D other){
		if(other.transform.localScale.x >.1 && other.tag != "Respawn")
			other.transform.localScale -= new Vector3(.007f,.007f,0);
	}
	void OnTriggerExit2D(Collider2D other){

	}
}
