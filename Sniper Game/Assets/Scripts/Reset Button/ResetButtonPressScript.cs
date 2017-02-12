using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResetButtonPressScript : MonoBehaviour //reloads the scene when the button is pressed
{

	void Start ()
    {
        SceneManager.LoadScene("Scene"); //reloads that one specific scene
        LivesManagerScript.GameOver = false; //resets the boolean that controls the game over screen and text

    }
	

	void Update ()
    {
	
	}
}
