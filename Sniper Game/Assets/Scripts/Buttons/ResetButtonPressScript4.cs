using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResetButtonPressScript4 : MonoBehaviour //reloads the scene when the button is pressed
{

    public void Restart()
    {
        Global.me.Timer = 30;
        Global.me.Reload = true; 
        Global.me.EnemiesKilled = 0; 
        Global.me.Won = false; 
        SceneManager.LoadScene("Scene4"); 
    }
}
