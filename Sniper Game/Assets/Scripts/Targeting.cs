using UnityEngine;
using System.Collections;

public class Targeting : MonoBehaviour // Targeting script. Sets the boundries and gives a movement input.
{
    //public numbers are used to allow for tweaks
    public float MovementSpeed = 0.3f; //Movement Speed for the reticle

    public float Leftbound = -25; //Left boundry
    public float Rightbound = 25; //Right boundry
    public float Topbound = 15; //Top boundry
    public float Bottombound = -15; //Bottom boundry

    Rigidbody2D rb; //establishes the ridgidbody 

	void Start () //Initialization
    {
        Application.targetFrameRate = 60;
        QualitySettings.vSyncCount = 1;
        rb = GetComponent<Rigidbody2D>(); //Initializes the ridgid body    
    }
	
	
	void Update () //Manages player input
    {
        InputMoving(); //function allowing for clarity and organization. It deals with the movement input

        Boundries(); //function allowing for clarity and orginization. It deals with the boundries of the reticle

        if(Input.GetKeyDown(KeyCode.R)) //button clicks
        {
            Global.me.Reload = true; //sets the boolean equal to true if the r button is pressed
        }
    }

    void InputMoving()
    {
        //Movement code using the updated ridgid body move position to allows for smooth movement and no phasing through walls

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
    }

    void Boundries()
    {
        //Boundries that reset the position of the reticle if they try to leave the scene (easier and cleaner than walls)

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
