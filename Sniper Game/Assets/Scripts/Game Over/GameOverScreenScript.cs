using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverScreenScript : MonoBehaviour //Manages when the game over screen appears
{
    Image GameOverScreen; //establishes the game over screen image

    void Start() //initializing 
    {
        GameOverScreen = GetComponent<Image>(); //initializing the image
    }

    void Update() // checking if the player has failed
    {
        if (LivesManagerScript.GameOver == true) //Checks if the player has failed
        {
            GameOverScreen.enabled = true; //activates the image script
        }
        else
        {
            GameOverScreen.enabled = false; //deactivates the image script
        }
    }
}
