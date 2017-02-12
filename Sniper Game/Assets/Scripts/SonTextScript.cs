using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SonTextScript : MonoBehaviour //Tells the player that they shouldn't hit the wrong target
{
    Text StopShootingText; //Initializes text

    void Start()
    {
        StopShootingText = GetComponent<Text>(); //Establishes the text script
    }


    void Update()
    {
        if (SonHitScript.SonTextDisplay == true) // If it gets the signal to display the text
        {
            StopShootingText.text = "Please don't shoot me, I am your son.";//tells the player that that isn't the target
        }
        if (SonHitScript.SonTextDisplay == false) // If it get the signal that it has moved out of the good guy 
        {
            StopShootingText.text = " ";//Clears the text so it doesn't stay there
        }
    }
}