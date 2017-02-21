using UnityEngine;
using System.Collections;

public class LivesManagerScript : MonoBehaviour //manages the lives of the sons
{

    public GameObject[] gameOverObjects; //an array of game objects
	
	void Update ()
    {
	    if(Global.me.SonsHit == 2) //If the sons are hit enough the game will be over
        {
            ShowGameOverScreen(); //activates the losing condition gameobjects
        }
	}

    void ShowGameOverScreen()
    {
        foreach (GameObject obj in gameOverObjects) //for loop that itterates for all the object in the array
        {
            obj.SetActive(true); //sets all the in the array gameobjects to active
        }
    }
}
