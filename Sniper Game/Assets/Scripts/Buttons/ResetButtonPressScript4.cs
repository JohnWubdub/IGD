using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResetButtonPressScript4 : MonoBehaviour //reloads the scene when the button is pressed
{

    public void Restart()
    {
        SonHitScript.SonTextDisplay = false; //resets the text
        Global.me.SonsHit = 0; //resets the number of sons hit
        Global.me.EnemiesKilled = 0; // resets the number of enemies killed
        SceneManager.LoadScene("Scene4"); //reloads that one specific scene  
    }
}
