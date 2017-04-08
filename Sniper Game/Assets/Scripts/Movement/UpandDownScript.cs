using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpandDownScript : MonoBehaviour
{

    Rigidbody2D rb; //establishes the ridgidbody

    //public booleans to decide which way the object will go
    public bool MovingUp = true;
    public bool MovingDown = false;

    //public floats to decide what space the object will occupy
    public float Topbound = 5; //Right boundry
    public float Bottombound = -5; //Left boundry

    public float MovementSpeed = 0.3f; //Sets the movement speed to a starting point 

    void Start() //initializing
    {
        rb = GetComponent<Rigidbody2D>(); //gets the ridgidbody
    }

    void Update() //updating the position of the object
    {
        patrolling(); //patrolling fuction is called this allows for this bit of code 
        //to be easily moved around and reconfigured without clogging up the update function
    }

    void patrolling() //deals with the movement of game objects
    {
        if (MovingUp == true) //When this is true the object moves right
        {
            rb.MovePosition(new Vector3(transform.position.x, transform.position.y + MovementSpeed, 0)); //uses the ridgid body to move the object allowing the object to be shot
            if (transform.position.y > Topbound) //same as the targeting bounds and can be changed based on the object
            {
                //controlling the direction of the object
                MovingUp = false;
                MovingDown = true;
            }
        }
        if (MovingDown == true)
        {
            rb.MovePosition(new Vector3(transform.position.x, transform.position.y - MovementSpeed, 0)); //uses the ridgid body to move the object allowing the object to be shot
            if (transform.position.y < Bottombound) //same as the targeting bounds and can be changed based on the object
            {
                //controlling the direction of the object
                MovingUp = true;
                MovingDown = false;
            }
        }

    }
}
