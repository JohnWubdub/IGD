using UnityEngine;
using System.Collections;

public class KillsManagerScript : MonoBehaviour //manages the number of kills and when to show the winning condition 
{

    public int RequiredKills = 1; //a number for the required kills for each scene or "level"

    public GameObject[] SuccessObjects; //an array of game objects
	
	void Update ()
    {
        if(Global.me.EnemiesKilled == RequiredKills) //if the player succeeds in completing the level
        {
            ShowGameOverScreen(); //activates the winning condition gameobjects
        }
	}

    void ShowGameOverScreen()
    {
        foreach (GameObject obj in SuccessObjects) //for loop that itterates for all the object in the array
        {
            obj.SetActive(true); //sets all the in the array gameobjects to active
        }
    }
}
