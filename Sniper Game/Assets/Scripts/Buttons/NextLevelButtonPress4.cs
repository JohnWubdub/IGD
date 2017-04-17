using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevelButtonPress4 : MonoBehaviour //script that runs when the next level button is pressed after completing the third level
{

    public void NextLevelButton()
    {
        SceneManager.LoadScene("Scene5"); 
        Global.me.Timer = 30; 
        Global.me.Reload = true; 
        Global.me.EnemiesKilled = 0; 
        Global.me.Won = false;
    }
}
