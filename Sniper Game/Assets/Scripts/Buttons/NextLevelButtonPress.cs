using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevelButtonPress : MonoBehaviour //script that runs when the next level button is pressed after completing the first level
{

    public void NextLevelButton()
    {
        SceneManager.LoadScene("Scene2"); 
        Global.me.Won = false;
        Global.me.Timer = 30;
        Global.me.Reload = true;
        Global.me.EnemiesKilled = 0;
    }
}
