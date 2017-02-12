using UnityEngine;
using System.Collections;

public class MovingScript : MonoBehaviour // Allows the object to move right then left and continue to loop until it stops
{

    Rigidbody2D rb; //establishes the ridgidbody

    //public booleans to decide which way the object will go
    public bool MovingRight = true;
    public bool MovingLeft = false;

    //public floats to decide what space the object will occupy
    public float Rightbound = 25; //Right boundry
    public float Leftbound = -25; //Left boundry


    public float MovementSpeed = 0.3f; //Sets the movement speed to a starting point 

    void Start () //initializing
    {
        rb = GetComponent<Rigidbody2D>(); //gets the ridgidbody
    }
	
	void Update () //updating the position of the object
    {
        patrolling(); //patrolling fuction is called this allows for this bit of code 
        //to be easily moved around and reconfigured without clogging up the update function
    }

    void patrolling() //deals with the movement of game objects
    {
        if (MovingRight == true) //When this is true the object moves right
        {
            rb.MovePosition(new Vector3(transform.position.x + MovementSpeed, transform.position.y, 0)); //uses the ridgid body to move the object allowing the object to be shot
            if (transform.position.x > Rightbound) //same as the targeting bounds and can be changed based on the object
            {
                //controlling the direction of the object
                MovingRight = false; 
                MovingLeft = true;
            }
        }
        if (MovingLeft == true)
        {
            rb.MovePosition(new Vector3(transform.position.x - MovementSpeed, transform.position.y, 0)); //uses the ridgid body to move the object allowing the object to be shot
            if (transform.position.x < Leftbound) //same as the targeting bounds and can be changed based on the object
            {
                //controlling the direction of the object
                MovingRight = true;
                MovingLeft = false;
            }
        }

    }
}
