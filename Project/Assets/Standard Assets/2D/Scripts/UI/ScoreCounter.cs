using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour

{
	public Collider2D Score;
	public int dScore;
	public Collider2D player;
	public Text txt;
	
    // Start is called before the first frame update
    void Start()

    {
		Score = this.gameObject.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
		if(player.IsTouching(Score)){ //checks if the player is touching the collider
				dScore = dScore + 1;
				Destroy(Score.gameObject);
				
		}
		
		txt.text = dScore.ToString(); //converts the score to a string to be displayed on the UI
		txt.text = "Score: " + dScore; //displays the score on the UI
    }

}
