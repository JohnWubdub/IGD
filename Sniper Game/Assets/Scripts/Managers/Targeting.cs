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

    public static bool SonTextDisplay = false; //Boolean to identify if the text should display

    void Start () //Initialization
    {
        Application.targetFrameRate = 60;
        QualitySettings.vSyncCount = 1;
        rb = GetComponent<Rigidbody2D>(); //Initializes the ridgid body    
    }
	
	
	void Update () //Manages player input
    {
        Shooting(); //function allowing for clarity and organization. It deals with the shooting

        InputMoving(); //function allowing for clarity and organization. It deals with the movement input

        Boundries(); //function allowing for clarity and orginization. It deals with the boundries of the reticle

        if(Input.GetKeyDown(KeyCode.R)) //button clicks
        {
            Global.me.Reload = true; //sets the boolean equal to true if the r button is pressed
            GetComponent<Sound>().Reload();
        } 
    }


    void Shooting() //handles the hit detection of the enemies and sends out the information regarding player kills to the other scripts
    {
        if (Input.GetKeyDown(KeyCode.Space) && Global.me.Reload == true) //Initiates the for loop when the space bar is pressed
        {
            Global.me.Reload = false; //the player needs to reload
            GetComponent<Sound>().Gunshot();

            Collider2D[] colArr = Physics2D.OverlapPointAll(new Vector2(transform.position.x, transform.position.y)); //creates an array of all the object that are overlapping that point
            for (int i = 0; i < colArr.Length; i++) //creates a for loop that goes through the array
            {
                Debug.Log(colArr[i]);
                if (colArr[i].gameObject.tag == "Red") //checking if it meets the requirments for an enemy
                {
                    colArr[i].gameObject.SetActive(false); //kill function
                    Global.me.EnemiesKilled += 1; //adds the point
                }
                if (colArr[i].gameObject.tag == "Blue") //checking if it meets the requirments for the son
                {
                    colArr[i].gameObject.SetActive(false); //kill function
                    Persist.sonsHit += 1; //adds the point
                }
            }
        }
    }

    void InputMoving()  //Movement code using the updated ridgid body move position to allows for smooth movement and no phasing through walls
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
    }

    void Boundries() //Boundries that reset the position of the reticle if they try to leave the scene (easier and cleaner than walls)
    {
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
