using UnityEngine;
using System.Collections;
using System;

public class Targeting : MonoBehaviour //This does fucking everything 
{
    
    public float MovementSpeed = 4f; 

    public float Leftbound = -25; 
    public float Rightbound = 25; 
    public float Topbound = 15; 
    public float Bottombound = -15; 
    

    ParticleSystem ps;

    Sound sound;

    private object moveVect;

    void Start () //Initialization
    {
        MovementSpeed = 20;
        Application.targetFrameRate = 60;
        QualitySettings.vSyncCount = 1;
        ps = GetComponent<ParticleSystem>();  
        sound = GetComponent<Sound>(); 
    }
	
	
	void Update () //Manages player input
    {
        if (Input.GetKeyDown(KeyCode.Space) && Global.me.Reload == true) 
        {
            Shooting();
        }
        InputMoving(); 

        Boundries();

        if(Input.GetKeyDown(KeyCode.R)) 
        {
            Global.me.Reload = true; 
            sound.Reload();
        }
        if (Input.GetKeyDown(KeyCode.Space) && Global.me.Reload == false) 
        {
            sound.DryFire();
        }
    }


    void Shooting() //handles the hit detection of the enemies and sends out the information regarding player kills to the other scripts
    {
        Global.me.screenshake.SetScreenShake(.4f, 1f, Vector3.right);

        Global.me.Reload = false;

        sound.Gunshot();

        Collider2D[] colArr = Physics2D.OverlapPointAll(new Vector2(transform.position.x, transform.position.y)); //creates an array of all the object that are overlapping that point
        for (int i = 0; i < colArr.Length; i++) //creates a for loop that goes through the array
        {
            if (colArr[i].gameObject.tag == "Red") //checking if it meets the requirments for an enemy
            {
                colArr[i].gameObject.SetActive(false); 
                Global.me.EnemiesKilled += 1; 
                ps.Play();
                Global.me.screenflash.Flash(.1f);
            }
            if (colArr[i].gameObject.tag == "Blue") //checking if it meets the requirments for the son
            {
                colArr[i].gameObject.SetActive(false); 
                Persist.sonsHit += 1; 
                Global.me.Timer += 5; 
                ps.Play();
                Global.me.screenflash.Flash(.1f);
            }
        }

    }

    void InputMoving()  //"Vectors man" -Gabe
    {
        Vector2 moveVect = Vector2.zero;
        if (Input.GetKey(KeyCode.W)) 
        {
            moveVect.y += 1;
        }

        if (Input.GetKey(KeyCode.S)) 
        {
            moveVect.y -= 1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveVect.x += 1;
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveVect.x -= 1;
        }
        moveVect = moveVect.normalized;
        transform.position += (Vector3)moveVect * Time.deltaTime * MovementSpeed;
    }
    
    void Boundries() //Smoooooooth as fuuuuuuck
    {
        
        if (transform.position.x < Leftbound) 
        {
            transform.position = (new Vector3(Leftbound, transform.position.y, 0));
        }

        if (transform.position.x > Rightbound)
        {
            transform.position = (new Vector3(Rightbound, transform.position.y, 0));
        }

        if (transform.position.y < Bottombound)
        {
            transform.position = (new Vector3(transform.position.x, Bottombound, 0));
        }

        if (transform.position.y > Topbound)
        {
            transform.position = (new Vector3(transform.position.x, Topbound, 0));
        }
    }
}
