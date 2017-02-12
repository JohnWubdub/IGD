using UnityEngine;
using System.Collections;

public class LivesManagerScript : MonoBehaviour //manages the lives of the sons
{
    public static int SonsHit = 0; //starts at 0

    public static bool GameOver = false; //the boolean is set to false so it can change later when there is a game over

    void Start ()
    {
	    
	}
	
	
	void Update ()
    {
	    if(SonsHit == 2) //If the sons are hit enough the game will be over
        {
            GameOver = true;//game over is now true for the image and the text
        }
	}
}
