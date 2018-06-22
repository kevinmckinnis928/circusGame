using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawn : MonoBehaviour {

	 private float nextActionTime = 0.0f;
	 public float period = 5f;

	 public Object greenBalloon;
	 public Object redBalloon;
	 public Object yellowBalloon;
     public Object blueBalloon;
     public Object whiteBalloon;

     private bool green;
	 private bool red;
	 private bool yellow;
     private bool blue;
     private bool white;

    public bool playmode = true;
    public bool firsttime = false;

	 public int currLevel;
     private int nextLevel;
	 public int balloonsLeft = 10;
	 public int balloonsPopped = 0;


	// Use this for initialization
	void Start () {


        currLevel = 1;

		green = false;
	 	red = false;
	 	yellow = false;
        blue = false;
        white = false;
        int random = Random.Range(0,5);
		if(random == 0) {
			green = true;
			Debug.Log("Look at Green Balloons");
		} else if (random == 1) {
			red = true;
			Debug.Log("Look at Red Balloons");
		} else if (random == 2) {
			yellow = true;
			Debug.Log("Look at Yellow Balloons");
		} else if (random == 3) {
            blue = true;
            Debug.Log("Look at Blue Balloons");
        } else {
            white = true;
            Debug.Log("Look at White Balloons");
        }



    }

	// Update is called once per frame
	void Update () {

        

        if (balloonsPopped == balloonsLeft && firsttime)
        {
            currLevel++;
            Debug.Log("Level " + currLevel);
            balloonsPopped = 0;
            period -= .1f;
            firsttime = false;
        }


        if (Time.timeScale == 1.0f)
        {
            if (Time.time > nextActionTime)
            {
                nextActionTime += period;
                if (green)
                {
                    Instantiate(greenBalloon, new Vector3(Random.Range(-11f, 6f),
                            this.transform.position.y, this.transform.position.z), Quaternion.identity);
                }
                else if (red)
                {
                    Instantiate(redBalloon, new Vector3(Random.Range(-11f, 6f),
                            this.transform.position.y, this.transform.position.z), Quaternion.identity);
                }
                else if (blue)
                {
                    Instantiate(blueBalloon, new Vector3(Random.Range(-11f, 6f),
                            this.transform.position.y, this.transform.position.z), Quaternion.identity);
                }
                else if (white)
                {
                    Instantiate(whiteBalloon, new Vector3(Random.Range(-11f, 6f),
                            this.transform.position.y, this.transform.position.z), Quaternion.identity);
                }
                else if (yellow)
                {
                    Instantiate(yellowBalloon, new Vector3(Random.Range(-11f, 6f),
                            this.transform.position.y, this.transform.position.z), Quaternion.identity);
                }
            }
        }



    }
}
