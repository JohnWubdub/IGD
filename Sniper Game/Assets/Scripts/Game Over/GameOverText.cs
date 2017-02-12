using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverText : MonoBehaviour // Manages the game over text
{ 
    Text Endtext; //establishes the game over text

    void Start() //initializing
    {
        Endtext = GetComponent<Text> (); //intializes the text
    }


    void Update()//checks if the player has failed
    {
        if (LivesManagerScript.GameOver == true) //checks if the player has fucked up enough
        { 
            Endtext.text = "You have failed as a father and a hit-man."; //Updates the Game Over text
        }
        else
        {
            Endtext.text = " "; //Updates the Game Over text
        }
    }
}
