using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour //Displays the time the player has left to complete the level
{
    Text TimeLeft; //intializes the text

    float TimeSubtraction = .05f; //the amount that the time dcreases by

	void Start ()
    {
        TimeLeft = GetComponent<Text>(); //Establishes the text script
    }
	
	
	void Update ()
    {
        Global.me.Timer -= TimeSubtraction; //starts the timer countdown
        TimeLeft.text = "TIME LEFT: " + Global.me.Timer; //displays the countdown
	}
}
