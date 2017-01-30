using UnityEngine;
using System.Collections;

public class BasicEnemyScript : MonoBehaviour
{

    public bool Overlapped = false; //boolean to check if is the reticle is on the target

    void Start ()
    {
        
	}
	
	
	void Update ()
    {
        if (Overlapped = true &&
            Input.GetKeyDown(KeyCode.Space)) //Checks if it is on the target 
        {
            Destroy(gameObject); //Destroys the game object
            Overlapped = false; //Resets the bool so other targets can be killed
        }
	
	}
    void OnTriggerEnter2D(Collider2D Object) //Checking it has collided with the reticle
    {
        Overlapped = true; //It has overlapped
    }
}
