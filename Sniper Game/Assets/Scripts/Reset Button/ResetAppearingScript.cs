using UnityEngine;
using System.Collections;

public class ResetAppearingScript : MonoBehaviour //loads the button when the player has failed
{
    public GameObject button; //establishes the button
	
	void Start ()
    {
	
	}
	
	
	void Update ()
    { 
      if (LivesManagerScript.GameOver == true) //Checks if the player has failed
      {
          button.SetActive(true); //sets the button to active so it displays
      }
      else
      {
          button.SetActive(false); //sets the button to not active so it doesn't display
      }
    }


}
