using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TutorialText : MonoBehaviour //Updates the tutorial text for the player
{
    Text Tutorial; //Initializes text

    void Start ()
    {
        Tutorial = GetComponent<Text>(); //Establishes the text script
    }
	
	
	void Update ()
    {
	    if(SonHitScript.SonTextDisplay == true) //so the text doens't overlap
        {
            Tutorial.text = " "; //updates the tutorial text
        }
        if(SonHitScript.SonTextDisplay == false) //so the text doesn't overlap
        {
            Tutorial.text = "DON'T SHOOT YOUR BLUE SONS. SHOOT THE RED TARGETS BEFORE TIME RUNS OUT! WASD TO MOVE, SPACEBAR TO SHOOT, AND  R TO RELOAD. "; //updates the tutorial text
        }
	}
}
