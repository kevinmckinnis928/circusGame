using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuSpawner : MonoBehaviour {

	 private float nextActionTime = 0.0f;
	 public float period = 5f;

	 public Object greenBalloon;
	 public Object redBalloon;
	 public Object yellowBalloon;
     public Object blueBalloon;
     public Object whiteBalloon;


	// Use this for initialization
	void Start () {

     
    }

	// Update is called once per frame
	void Update () {

       


            if (Time.time > nextActionTime)
            {
                nextActionTime += period;
                
                int random = Random.Range(0, 5);
                if (random == 0)
                {
                    Instantiate(redBalloon, new Vector3(Random.Range(-11f, 6f),
                    this.transform.position.y, this.transform.position.z), Quaternion.identity);
                }
                else if (random == 1)
                {
                    Instantiate(greenBalloon, new Vector3(Random.Range(-11f, 6f),
                    this.transform.position.y, this.transform.position.z), Quaternion.identity);
                }
                else if (random == 2)
                {
                    Instantiate(whiteBalloon, new Vector3(Random.Range(-11f, 6f),
                    this.transform.position.y, this.transform.position.z), Quaternion.identity);
                }
                else if (random == 3)
                {
                    Instantiate(blueBalloon, new Vector3(Random.Range(-11f, 6f),
                    this.transform.position.y, this.transform.position.z), Quaternion.identity);
                }
                else
                {
                    Instantiate(yellowBalloon, new Vector3(Random.Range(-11f, 6f),
                    this.transform.position.y, this.transform.position.z), Quaternion.identity);
                }
                
                
            }
        


	}
}
