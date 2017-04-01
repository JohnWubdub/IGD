using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ReloadTextScript : MonoBehaviour //displays the reload text when the player needs to reload
{
    Text ReloadText; //initalizes

	void Start ()
    {
        ReloadText = GetComponent<Text>(); //get the component
	}
	
	void Update ()
    {
        if (Global.me.Reload == false) //checks if the player has reloaded
        {
            ReloadText.text = "RELOAD!"; //updates the reload text to warn the player that they need to reload
        }
        if (Global.me.Reload == true) //checks if the player has reloaded
        {
            ReloadText.text = " "; //updates the reload text so it doesn't show
        }
	}
}
