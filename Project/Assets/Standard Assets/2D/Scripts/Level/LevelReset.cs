using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelReset :MonoBehaviour
{
	public GameObject Panel;
	public Collider2D player;
	public Collider2D killZone;

	
	void Start(){
		Panel.SetActive(false); //disables the "You Died" pannel
	}


    void Update()
    {
		if (player.IsTouching(killZone)){ //checks if the player is colliding with the kill zone
			Panel.SetActive(true); //sets the death panel to true if the player reaches the kill zone
		}
			
    }
	
	public void button(){
		SceneManager.LoadScene(SceneManager.GetSceneAt(0).name); //reloads the current scene
	}
	
	public void button2(){
		SceneManager.LoadScene(0); //loads the title
	}
}
