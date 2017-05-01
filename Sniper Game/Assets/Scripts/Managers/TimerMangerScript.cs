using UnityEngine;
using System.Collections;

public class TimerMangerScript : MonoBehaviour //manages the timer and the gameover state
{

    public GameObject[] gameOverObjects; 

    public GameObject[] gameOverObjectsV2;

    public GameObject[] gameOverObjectsV3;

    public GameObject[] gameOverObjectsV4;

    void Update()
    {
        if (Global.me.Timer < 0 && Global.me.Won == false) 
        {
            ShowGameOverScreen();
            Global.me.Fail = true; 
        }
    }

    void ShowGameOverScreen()
    {
        if (Persist.sonsHit == 0)
        {
            foreach (GameObject obj in gameOverObjects) 
            {
                obj.SetActive(true); 
            }
        }
        if (Persist.sonsHit == 1)
        {
            foreach (GameObject obj in gameOverObjects) 
            {
                obj.SetActive(true); 
            }
        }
        if (Persist.sonsHit == 2)
        {
            foreach (GameObject obj in gameOverObjects) 
            {
                obj.SetActive(true);
            }
        }
        if (Persist.sonsHit == 3)
        {
            foreach (GameObject obj in gameOverObjectsV2)
            {
                obj.SetActive(true); 
            }
        }
        if (Persist.sonsHit == 4)
        {
            foreach (GameObject obj in gameOverObjectsV2) 
            {
                obj.SetActive(true); 
            }
        }
        if (Persist.sonsHit == 5)
        {
            foreach (GameObject obj in gameOverObjectsV3) 
            {
                obj.SetActive(true); 
            }
        }
        if (Persist.sonsHit == 6)
        {
            foreach (GameObject obj in gameOverObjectsV3) 
            {
                obj.SetActive(true); 
            }
        }
        if (Persist.sonsHit >= 7)
        {
            foreach (GameObject obj in gameOverObjectsV4) 
            {
                obj.SetActive(true); 
            }
        }
    }
}
