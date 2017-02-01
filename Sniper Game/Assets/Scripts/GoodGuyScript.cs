using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GoodGuyScript : MonoBehaviour
{
    //Script for basic good guy 

    Text StopShootingText;

    public bool OverlappedGoodGuy = false; //boolean to check if is the reticle is on the good guy

    void Start ()
    {
        StopShootingText = GetComponent<Text>();
    }
	
	
	void Update ()
    {
       if (OverlappedGoodGuy = true &&
           Input.GetKeyDown(KeyCode.Space)) //Checks if it is on the target 
       {
            StopShootingText.text = "That's not the target!";
       }

    }

       void OnTriggerEnter2D(Collider2D Object) //Checking it has collided with the reticle
       {
         OverlappedGoodGuy = true; //It has overlapped
       }
    

}

