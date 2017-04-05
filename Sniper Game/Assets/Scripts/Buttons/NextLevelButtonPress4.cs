using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevelButtonPress4 : MonoBehaviour //script that runs when the next level button is pressed after completing the third level
{

    public void NextLevelButton()
    {
        SceneManager.LoadScene("Scene5"); //reloads the next scene 
        Global.me.Timer = 30; //resets the timer
        Global.me.Reload = true; //sets it so they don't have to reload when they start the level
        Global.me.EnemiesKilled = 0; // resets the number of enemies killed
        Global.me.Won = false;
    }
}
