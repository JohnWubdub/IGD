using UnityEngine;
using System.Collections;

public class Targeting : MonoBehaviour // Targeting script. Sets the boundries and gives the player movement input.
{ 

    public float MovementSpeed; //public number to allow for chnages during gameplay
    public float Leftbound = -25; //Left boundry
    public float Rightbound = 25; //Right boundry
    public float Topbound = 10; //Top boundry
    public float Bottombound = -10; //Bottom boundry
    Rigidbody2D rb; //establishes the ridgidbody 

	void Start ()
    {
	    rb = GetComponent<Rigidbody2D>(); //gets the ridgidbody 
	}
	
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.W)) //Upward Movement
        {
           rb.MovePosition(new Vector3(transform.position.x, transform.position.y + MovementSpeed, 0)); 
        }
        if (Input.GetKey(KeyCode.S)) //Downward Movement
        {
            rb.MovePosition(new Vector3(transform.position.x, transform.position.y - MovementSpeed, 0)); 
        }
        if (Input.GetKey(KeyCode.D)) //Rightward Movement
        {
            rb.MovePosition(new Vector3(transform.position.x + MovementSpeed, transform.position.y, 0)); 
        }
        if (Input.GetKey(KeyCode.A)) //Leftward Movement
        {
            rb.MovePosition(new Vector3(transform.position.x - MovementSpeed, transform.position.y, 0)); 
        }
        if (transform.position.x < Leftbound) //Left boundry 
        {
            rb.MovePosition(new Vector3(Leftbound, transform.position.y, 0));
        }
        if (transform.position.x > Rightbound) //Right boundry
        {
            rb.MovePosition(new Vector3(Rightbound, transform.position.y, 0));
        }
        if (transform.position.y < Bottombound) //Bottom boundry
        {
            rb.MovePosition(new Vector3(transform.position.x, Bottombound, 0));
        }
        if (transform.position.y > Topbound) //Top boundry
        {
            rb.MovePosition(new Vector3(transform.position.x, Topbound, 0));
        }

    }
}
