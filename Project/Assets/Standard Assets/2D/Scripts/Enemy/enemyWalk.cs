using UnityEngine;
using System.Collections;

public class enemyWalk : MonoBehaviour {

    public float speed; //Puts the speed in the inspector so it can be edited.
    public Rigidbody2D rb; //Store a reference to the Rigidbody2D component required to use 2D Physics.
	public float start;
	public float end;
	public float endPos;
	public float x;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D> (); //stores the rigid body
		start = transform.position.x + 0.05f; //Gets the position the enemy starts at and stores it
		endPos = transform.position.x + end - 0.05f; //Gets the position of enemy at the start then adds it to the value that dictates how far it should walk
    }

    void Update()
    {
    Move(); //calls the move class
	} 


	void Move() { 

	if(transform.position.x <= start){ //checks if it is at start position
		x = 1;
	}
	else if(transform.position.x >= endPos){ //checks if it is at end position
		x = -1;
	
	}	
	
    float moveBy = x * speed; //increases or decreases the enemy x coordinate in order to move left or right
    rb.velocity = new Vector2(moveBy, rb.velocity.y); //changes the velocity of the rigid body so the enemy can move
	}
	
}

