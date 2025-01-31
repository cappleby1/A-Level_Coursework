using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPickUp : MonoBehaviour
{
	public GameObject[] crates;
	public GameObject crate;
	public float interactDis;
	private bool pickedUp;
	public float rotationSpeed;
	public GameObject Hold;
    
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(pickedUp){
			float mouseX = Input.GetAxis("Mouse X") * -rotationSpeed;
			crate.transform.RotateAround(transform.position, Vector3.forward, mouseX);
			crate.transform.position = Hold.transform.position;
			
			if (Input.GetMouseButtonDown(0)) {
				drop(crate);
				
				
				
				
			}

		}
		if (Input.GetMouseButtonDown(0))
			{
			try{
				RaycastHit2D rayHit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));
				float num = Vector3.Distance(rayHit.transform.position, transform.position);
				crate = rayHit.transform.gameObject;
				if(num < interactDis) {
					pickup(crate);
					
					
				}
			} catch {
				//
			}
		}
	}    
	
	private void pickup(GameObject crate){
		for(int i = 0; i < crates.Length; i++){
			
			pickedUp = true;
			
			crate.GetComponent<Collider2D>().enabled = false;
			crate.GetComponent<Rigidbody2D>().isKinematic = true;
		}
	}
	private void drop(GameObject crate){
		for(int i = 0; i < crates.Length; i++){
			pickedUp = false;
			
			crate.GetComponent<Collider2D>().enabled = true;
			crate.GetComponent<Rigidbody2D>().isKinematic = false;
		}
	}
}

