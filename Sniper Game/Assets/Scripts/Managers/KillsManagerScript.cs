using UnityEngine;
using System.Collections;

public class KillsManagerScript : MonoBehaviour //manages the number of kills and when to show the winning condition 
{

    public int RequiredKills = 1; //a number for the required kills for each scene or "level"

    public GameObject[] SuccessObjects; //an array of game objects

    public GameObject[] SuccessObjectsV2; //an array of game objects

    public GameObject[] SuccessObjectsV3; //an array of game objects

    public GameObject[] SuccessObjectsV4; //an array of game objects

    void Update ()
    {
        if(Global.me.EnemiesKilled == RequiredKills) //if the player succeeds in completing the level
        {
            ShowWinningScreen(); //activates the winning condition gameobjects
            Global.me.Won = true;
        }
	}

    void ShowWinningScreen()
    {
        if (Persist.sonsHit == 0)
        {
            foreach (GameObject obj in SuccessObjects) //for loop that itterates for all the object in the array
            {
                obj.SetActive(true); //sets all the in the array gameobjects to active
            }
        }
        if (Persist.sonsHit == 1)
        {
            foreach (GameObject obj in SuccessObjects) //for loop that itterates for all the object in the array
            {
                obj.SetActive(true); //sets all the in the array gameobjects to active
            }
        }
        if (Persist.sonsHit == 2)
        {
            foreach (GameObject obj in SuccessObjects) //for loop that itterates for all the object in the array
            {
                obj.SetActive(true); //sets all the in the array gameobjects to active
            }
        }
        if (Persist.sonsHit == 3)
        {
            foreach (GameObject obj in SuccessObjectsV2) //for loop that itterates for all the object in the array
            {
                obj.SetActive(true); //sets all the in the array gameobjects to active
            }
        }
        if (Persist.sonsHit == 4)
        {
            foreach (GameObject obj in SuccessObjectsV2) //for loop that itterates for all the object in the array
            {
                obj.SetActive(true); //sets all the in the array gameobjects to active
            }
        }
        if (Persist.sonsHit == 5)
        {
            foreach (GameObject obj in SuccessObjectsV3) //for loop that itterates for all the object in the array
            {
                obj.SetActive(true); //sets all the in the array gameobjects to active
            }
        }
        if (Persist.sonsHit == 6)
        {
            foreach (GameObject obj in SuccessObjectsV3) //for loop that itterates for all the object in the array
            {
                obj.SetActive(true); //sets all the in the array gameobjects to active
            }
        }
        if (Persist.sonsHit >= 7)
        {
            foreach (GameObject obj in SuccessObjectsV4) //for loop that itterates for all the object in the array
            {
                obj.SetActive(true); //sets all the in the array gameobjects to active
            }
        }
    }
}
