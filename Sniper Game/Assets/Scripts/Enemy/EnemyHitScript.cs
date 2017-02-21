using UnityEngine;
using System.Collections;

public class EnemyHitScript : MonoBehaviour //Basic (not moving) enemy script. It understands when the reticle is over the object and knows when it's not 
{

    bool Overlapped = false; //boolean to check if is the reticle is on the target

    void Update()
    {
        if (Overlapped &&
            Input.GetKeyDown(KeyCode.Space)) //Checks if it is on the target and if the space bar is pressed
        {
            Destroy(gameObject); //Destroys the game object
            Global.me.EnemiesKilled += 1; 
        }

    }
    void OnTriggerEnter2D(Collider2D Object) //Checking it has collided with the reticle
    {
        if (Object.gameObject.tag == "target") //Checks if the game object has the tag of "target"
        {
            Overlapped = true; //sets the boolean equal to true 
        }
    }

    void OnTriggerExit2D(Collider2D Object) //Checking if the game object left area
    {
        if (Object.gameObject.tag == "target") //checks if the game object is the target
        {
            Overlapped = false; //sets the boolean equal to true
        }
    }
}
