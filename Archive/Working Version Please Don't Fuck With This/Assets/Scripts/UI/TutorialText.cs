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
      Tutorial.text = "SHOOT THE RED TARGETS BEFORE TIME RUNS OUT! WASD TO MOVE, SPACEBAR TO SHOOT, AND  R TO RELOAD. "; //updates the tutorial text
    }
	
}
