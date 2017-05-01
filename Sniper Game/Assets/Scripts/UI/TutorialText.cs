using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TutorialText : MonoBehaviour //Updates the tutorial text for the player
{
    Text Tutorial; 

    void Start ()
    {
        Tutorial = GetComponent<Text>(); 
    }
	
	
	void Update ()
    { 
      Tutorial.text = "SHOOT THE RED TARGETS BEFORE TIME RUNS OUT! WASD TO MOVE, SPACEBAR TO SHOOT, AND U-J-K TO RELOAD."; 
    }
	
}
