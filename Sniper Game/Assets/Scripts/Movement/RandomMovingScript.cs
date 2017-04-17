using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovingScript : MonoBehaviour //manages the random movement 
{
    Rigidbody2D rb;
    
    public bool MovingRight = true;
    public bool MovingLeft = false;
    private float MovementSpeed;
    private float Rightbound;
    private float Leftbound;

    void Awake()
    {
        Leftbound = Random.Range(-10f, -25f); 
        Rightbound = Random.Range(10f, 25f);
        MovementSpeed = Random.Range(.2f, .4f);
    }
       
   

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
