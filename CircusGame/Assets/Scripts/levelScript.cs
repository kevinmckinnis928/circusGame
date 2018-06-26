using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelScript : MonoBehaviour {

    private int level;

    private float nextActionTime = 0.0f;
    public float period = 2f;

    public GameObject levelMenuUI;

    public Text lvlT;

    // Use this for initialization
    void Start () {
        level = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if(GameObject.Find("balloonSpawn").GetComponent<BalloonSpawn>().currLevel > level)
        {
            level = GameObject.Find("balloonSpawn").GetComponent<BalloonSpawn>().currLevel;
            lvlT.text = "Level " + level.ToString();
            levelMenuUI.SetActive(true);
        }

        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            if (levelMenuUI.activeSelf == true)
            {
                levelMenuUI.SetActive(false);
            }
        }

    }
}
