using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ReloadTextScript : MonoBehaviour //displays the reload text when the player needs to reload
{
    Text ReloadText;

	void Start ()
    {
        ReloadText = GetComponent<Text>();
	}
	
	void Update ()
    {
        if (Global.me.Reload == false)
        {
            ReloadText.text = "RELOAD!"; 
        }
        if (Global.me.Reload == true) 
        {
            ReloadText.text = " "; 
        }
	}
}
