using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevelButtonPress4 : MonoBehaviour //script that runs when the next level button is pressed after completing the third level
{

    public void NextLevelButton()
    {
        Global.me.SonsHit = 0; //resets the number of sons hit
        Global.me.EnemiesKilled = 0; // resets the number of enemies killed
        SceneManager.LoadScene("Scene5"); //reloads the next scene 
    }
}
