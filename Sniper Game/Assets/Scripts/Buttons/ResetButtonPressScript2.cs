using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResetButtonPressScript2 : MonoBehaviour //reloads the scene when the button is pressed
{

    public void Restart()
    {
        Global.me.EnemiesKilled = 0; // resets the number of enemies killed
        Global.me.Timer = 30; //resets the timer
        Global.me.Reload = true; //sets it so they don't have to reload when they start the level
        Global.me.Won = false;
        SceneManager.LoadScene("Scene2"); //reloads that one specific scene  
    }
}
