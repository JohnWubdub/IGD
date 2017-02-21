using UnityEngine;
using System.Collections;

public class SonHitScript: MonoBehaviour //Script that takes care of when the player shoots one of their child 
    //It understands when the reticle is over your child and it talks with the live manager as well as the text that displays when you shoot your son
{
    bool Overlapped = false; //Boolean to manage if the reticle is overlapping the son

    public static bool SonTextDisplay = false; //Boolean to identify if the text should display 

    void Update() //Checking for input and overlap
    {
        if (Overlapped &&
            Input.GetKeyDown(KeyCode.Space)) //Checks if the reticle is overlapping the son and if the space bar has been pressed
        {
            SonTextDisplay = true; //Displays the text saying you shot your son
            Global.me.SonsHit += 1; //Keeping track of everytime a son gets shot 
        }

    }
    void OnTriggerEnter2D(Collider2D Object) //Checking if the reticle is on the son
    {
        if (Object.gameObject.tag == "target") //Checks if the colliding game object has the targeting tag
        {
            Overlapped = true; //sets the boolean equal to true when it has entered 
        }
    }

    void OnTriggerExit2D(Collider2D Object) //Checking if the game object left area
    {
        if (Object.gameObject.tag == "target") //checks if the colliding game object has the targeting tag
        {
            Overlapped = false; //resets the boolean so the player can shoot other targets
            SonTextDisplay = false; //sets the boolean to false so the text clears 
        }
    }
}