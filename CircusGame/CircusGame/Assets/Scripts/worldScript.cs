using UnityEngine;

public class worldScript : MonoBehaviour {

	public int playerLives = 3;
	public int playerPoints = 0;


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if(playerLives <= 0) 
			GameObject.Find("ButtonManager").GetComponent<buttonManager>().gameOver = true;
	}
	
}
