using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevelButtonPress3 : MonoBehaviour //script that runs when the next level button is pressed after completing the second level
{

    public void NextLevelButton()
    {
        Global.me.SonsHit = 0; //resets the number of sons hit
        Global.me.EnemiesKilled = 0; // resets the number of enemies killed 
        SceneManager.LoadScene("Scene4"); //loads the next scene
    }
}
