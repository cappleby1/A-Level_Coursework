using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
	public float seconds;
	public float minute;
	public float hour;
	public Text timer;
	public Collider2D player;
	public Collider2D flag;
	public bool finished;
	
    // Start is called before the first frame update
    void Start()
    {
		finished = false;
        
    }

    // Update is called once per frame
    void Update()
    {
		 if(finished == false){
		 seconds += Time.deltaTime; //increases seconds
		 timer.text = hour +"h:"+ minute +"m:"+(int)seconds + "s"; //sets the format to have seconds, minutes and hours
		 if(seconds >= 60){ //adds to minutes once seconds gets to 60
			 minute++;
			 seconds %= 60;
			 if(minute >= 60){ //increases hours if minutes gets to 60
				 hour++;
				 minute %= 60;
			 }
		 }
			 
						
		 }
		
		if (player.IsTouching(flag)){
			finished = true;
		}
 }
}
