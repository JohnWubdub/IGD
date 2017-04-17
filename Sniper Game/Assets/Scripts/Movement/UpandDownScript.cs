using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpandDownScript : MonoBehaviour //Deals with up and down movement 
{

    Rigidbody2D rb; 
    
    public bool MovingUp = true;
    public bool MovingDown = false;
    
    public float Topbound = 5; 
    public float Bottombound = -5; 

    public float MovementSpeed = 0.3f;

    void Start() 
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        patrolling();
    }

    void patrolling() 
    {
        if (MovingUp == true) 
        {
            rb.MovePosition(new Vector3(transform.position.x, transform.position.y + MovementSpeed, 0)); 
            if (transform.position.y > Topbound) 
            {
                MovingUp = false;
                MovingDown = true;
            }
        }
        if (MovingDown == true)
        {
            rb.MovePosition(new Vector3(transform.position.x, transform.position.y - MovementSpeed, 0)); 
            if (transform.position.y < Bottombound) 
            {
                MovingUp = true;
                MovingDown = false;
            }
        }

    }
}
