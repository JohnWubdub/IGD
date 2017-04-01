using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevelButtonPress3 : MonoBehaviour //script that runs when the next level button is pressed after completing the second level
{

    public void NextLevelButton()
    {
        SceneManager.LoadScene("Scene4"); //loads the next scene
        Global.me.Timer = 30; //resets the timer
        Global.me.Reload = true; //sets it so they don't have to reload when they start the level
        Global.me.EnemiesKilled = 0; // resets the number of enemies killed 
    }
}
