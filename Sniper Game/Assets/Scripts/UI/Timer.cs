using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour //Displays the time the player has left to complete the level
{
    Text TimeLeft; 

	void Start ()
    {
        TimeLeft = GetComponent<Text>(); 
    }
	
	
	void Update ()
    {
        Global.me.Timer -= Time.deltaTime; 
        TimeLeft.text = "TIME LEFT: " + Global.me.Timer; 
	}
}
