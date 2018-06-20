using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonBehavior : MonoBehaviour {

    public Object pop;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		//pauseMenu pause = GameObject.Find("PauseMenu").GetComponent<pauseMenu>();

		//if(pause.gamePaused == false)
        	this.transform.Translate(0, .03f, 0);

        if (this.transform.localScale.x <= .3f) {
            GameObject.Find("player").GetComponent<worldScript>().playerPoints++;
            GameObject.Find("balloonSpawn").GetComponent<BalloonSpawn>().balloonsPopped++;
            GameObject.Find("balloonSpawn").GetComponent<BalloonSpawn>().firsttime = true;
            Instantiate(pop, this.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
