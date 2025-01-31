using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndFlag : MonoBehaviour
{
	public Collider2D player;
	public Collider2D flag;
	public GameObject winText;
	public GameObject winPanel;
	public int level;

	
    // Start is called before the first frame update
    void Start()
    {
	   winText.SetActive(false); //makes the text invisible until level complete
	   level = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.IsTouching(flag)){ //checks if the player has reached the flag
		winText.SetActive(true); //sets the text to visible so that it can be seen
		winPanel.SetActive(true);
		
		}
    }
	
}
