using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResetButtonPressScript5 : MonoBehaviour //reloads the scene when the button is pressed
{

    public void Restart()
    {
        SonHitScript.SonTextDisplay = false; //resets the text
        Global.me.SonsHit = 0; //resets the number of sons hit
        Global.me.Timer = 30; //resets the timer
        Global.me.Reload = true; //sets it so they don't have to reload when they start the level
        Global.me.EnemiesKilled = 0; // resets the number of enemies killed
        SceneManager.LoadScene("Scene5"); //reloads that one specific scene  
    }
}
