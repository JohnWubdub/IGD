using UnityEngine;
using System.Collections;

public class MovingScript : MonoBehaviour // Allows the object to move right then left 
{

    Rigidbody2D rb;  
    
    public bool MovingRight = true;
    public bool MovingLeft = false;
    
    public float Rightbound = 25; 
    public float Leftbound = -25; 

    public float MovementSpeed = 0.3f;  

    void Start () 
    {
        rb = GetComponent<Rigidbody2D>();
    }
	
	void Update () 
    {
        patrolling();
    }

    void patrolling() //deals with the movement of game objects
    {
        if (MovingRight == true) 
        {
            rb.MovePosition(new Vector3(transform.position.x + MovementSpeed, transform.position.y, 0)); 
            if (transform.position.x > Rightbound) 
            {
                MovingRight = false; 
                MovingLeft = true;
            }
        }
        if (MovingLeft == true)
        {
            rb.MovePosition(new Vector3(transform.position.x - MovementSpeed, transform.position.y, 0)); 
            if (transform.position.x < Leftbound) 
            {
                MovingRight = true;
                MovingLeft = false;
            }
        }

    }
}