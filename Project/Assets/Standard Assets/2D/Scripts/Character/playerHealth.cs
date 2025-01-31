using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
	public int pHealth;
	public Collider2D player;
	public Collider2D[] enemy;
	public GameObject Panel;
	public bool invincible = false;
	public Text txt;
	
    // Start is called before the first frame update
    void Start()
    {
		pHealth = 4; //sets the initial health
        
    }

    // Update is called once per frame
    void Update()
    {
		for(int i = 0; i < enemy.Length; i++){ //checks if the enemy is in range of the player
			if(player.IsTouching(enemy[i]) && invincible == false){
				pHealth = pHealth - 1; //will reduce the player health by one
				invincible = true; //sets a value to true so that the player does not loose health exponentially
				StartCoroutine(wait()); //waits for real time seconds
			}
		}
		if(pHealth == 0){ //checks if the players health is at 0
			Panel.SetActive(true);
		}
		txt.text = pHealth.ToString(); //converts the health to a string to be displayed on the UI
		txt.text = "Health: " + pHealth; //displays the health on the UI 
		
    }
	
	IEnumerator wait(){ 
		yield return new WaitForSeconds(3f); //sets real time so the player does not loose health exponentially
		invincible = false; //sets the value back to false so the player can be hit again
	}
}
