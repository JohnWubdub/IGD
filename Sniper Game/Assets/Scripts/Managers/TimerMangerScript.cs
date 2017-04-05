using UnityEngine;
using System.Collections;

public class TimerMangerScript : MonoBehaviour //manages the time and the gameover state
{

    public GameObject[] gameOverObjects; //an array of game objects

    public GameObject[] gameOverObjectsV2;

    public GameObject[] gameOverObjectsV3;

    public GameObject[] gameOverObjectsV4;

    void Update()
    {
        if (Global.me.Timer < 0 && Global.me.Won == false) //If the sons are hit enough the game will be over
        {
            ShowGameOverScreen(); //activates the losing condition gameobjects
        }
    }

    void ShowGameOverScreen()
    {
        if (Persist.sonsHit == 0)
        {
            foreach (GameObject obj in gameOverObjects) //for loop that itterates for all the object in the array
            {
                obj.SetActive(true); //sets all the in the array gameobjects to active
            }
        }
        if (Persist.sonsHit == 1)
        {
            foreach (GameObject obj in gameOverObjects) //for loop that itterates for all the object in the array
            {
                obj.SetActive(true); //sets all the in the array gameobjects to active
            }
        }
        if (Persist.sonsHit == 2)
        {
            foreach (GameObject obj in gameOverObjects) //for loop that itterates for all the object in the array
            {
                obj.SetActive(true); //sets all the in the array gameobjects to active
            }
        }
        if (Persist.sonsHit == 3)
        {
            foreach (GameObject obj in gameOverObjectsV2) //for loop that itterates for all the object in the array
            {
                obj.SetActive(true); //sets all the in the array gameobjects to active
            }
        }
        if (Persist.sonsHit == 4)
        {
            foreach (GameObject obj in gameOverObjectsV2) //for loop that itterates for all the object in the array
            {
                obj.SetActive(true); //sets all the in the array gameobjects to active
            }
        }
        if (Persist.sonsHit == 5)
        {
            foreach (GameObject obj in gameOverObjectsV3) //for loop that itterates for all the object in the array
            {
                obj.SetActive(true); //sets all the in the array gameobjects to active
            }
        }
        if (Persist.sonsHit == 6)
        {
            foreach (GameObject obj in gameOverObjectsV3) //for loop that itterates for all the object in the array
            {
                obj.SetActive(true); //sets all the in the array gameobjects to active
            }
        }
        if (Persist.sonsHit >= 7)
        {
            foreach (GameObject obj in gameOverObjectsV4) //for loop that itterates for all the object in the array
            {
                obj.SetActive(true); //sets all the in the array gameobjects to active
            }
        }
    }
}
