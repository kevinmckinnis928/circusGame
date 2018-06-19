using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crosshairScript : MonoBehaviour {


	 //private bool dest = false;

	 public int playerLives = 3;

	// Use this for initialization
	void Start () {
		 Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
     	Vector3 temp = Input.mousePosition;
   		temp.z = 10f; // Set this to be the distance you want the object to be placed in front of the camera.
   		this.transform.position = Camera.main.ScreenToWorldPoint(temp);
	}

	void OnTriggerEnter2D(Collider2D other){
		//dest = true;

	}
	void OnTriggerStay2D(Collider2D other){
		if(other.transform.localScale.x >.1 && other.tag != "Respawn")
			other.transform.localScale -= new Vector3(.007f,.007f,0);
	}
	void OnTriggerExit2D(Collider2D other){
		//dest = false;
	}
}
