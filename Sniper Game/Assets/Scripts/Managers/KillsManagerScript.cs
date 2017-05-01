using UnityEngine;
using System.Collections;

public class KillsManagerScript : MonoBehaviour //manages the number of kills and when to show the winning condition 
{

    public int RequiredKills = 1; 

    public GameObject[] SuccessObjects;

    public GameObject[] SuccessObjectsV2;

    public GameObject[] SuccessObjectsV3;

    public GameObject[] SuccessObjectsV4;

    void Update ()
    {
        if(Global.me.EnemiesKilled == RequiredKills && Global.me.Fail == false) 
        {
            ShowWinningScreen(); 
            Global.me.Won = true;
        }
	}

    void ShowWinningScreen()
    {
        if (Persist.sonsHit == 0)
        {
            foreach (GameObject obj in SuccessObjects) 
            {
                obj.SetActive(true); 
            }
        }
        if (Persist.sonsHit == 1)
        {
            foreach (GameObject obj in SuccessObjects)
            {
                obj.SetActive(true);
            }
        }
        if (Persist.sonsHit == 2)
        {
            foreach (GameObject obj in SuccessObjects)
            {
                obj.SetActive(true);
            }
        }
        if (Persist.sonsHit == 3)
        {
            foreach (GameObject obj in SuccessObjectsV2)
            {
                obj.SetActive(true);
            }
        }
        if (Persist.sonsHit == 4)
        {
            foreach (GameObject obj in SuccessObjectsV2)
            {
                obj.SetActive(true); 
            }
        }
        if (Persist.sonsHit == 5)
        {
            foreach (GameObject obj in SuccessObjectsV3)
            {
                obj.SetActive(true);
            }
        }
        if (Persist.sonsHit == 6)
        {
            foreach (GameObject obj in SuccessObjectsV3)
            {
                obj.SetActive(true); 
            }
        }
        if (Persist.sonsHit >= 7)
        {
            foreach (GameObject obj in SuccessObjectsV4) 
            {
                obj.SetActive(true); 
            }
        }
    }
}
