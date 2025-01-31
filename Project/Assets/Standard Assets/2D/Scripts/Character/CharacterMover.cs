using UnityEngine;
using System.Collections;

public class CharacterMover : MonoBehaviour {

    public float speed; //Puts the speed in the inspector so it can be edited.
	public float jumpForce; //Puts the jump force is inspector so it can be edited
    public Rigidbody2D rb; //Store a reference to the Rigidbody2D component required to use 2D Physics.
	public Collider2D player;
	public Collider2D[] platform; 
	public Collider2D[] rocks;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D> (); //stores the rigid body
    }

    void Update()
    {
		Move(); //calls the move class
		if (Input.GetKeyDown(KeyCode.Space)){
			floorCheck();
			rockCheck();
		}
	} 


	void Move() { 
		float x = Input.GetAxisRaw("Horizontal");  //gets the current x coordinate of the player
		float moveBy = x * speed; //increases or decreases the players x coordinate in order to move left or right
		rb.velocity = new Vector2(moveBy, rb.velocity.y); //changes the velocity of the rigid body so the player can move
	}
	
	void Jump() { 
			if (Input.GetKeyDown(KeyCode.Space)) { //checks if space is pressed
				rb.velocity = new Vector2(rb.velocity.x, jumpForce); //increases the players height in order to jump
			
			} 
		}
	
	
	void floorCheck(){
		for(int i = 0; i < platform.Length; i++ ){
			if(player.IsTouching(platform[i])){
				Jump();
			}
		}
	}
	void rockCheck(){
		for(int i = 0; i < rocks.Length; i++ ){
			if(player.IsTouching(rocks[i])){
				Jump();
			}
		}
	}

}
