using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevelButtonPress3 : MonoBehaviour //script that runs when the next level button is pressed after completing the second level
{

    public void NextLevelButton()
    {
        SceneManager.LoadScene("Scene4"); 
        Global.me.Timer = 30; 
        Global.me.Reload = true;
        Global.me.EnemiesKilled = 0; 
        Global.me.Won = false;
    }
}
