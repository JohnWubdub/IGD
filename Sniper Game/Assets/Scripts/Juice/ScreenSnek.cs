using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSnek : MonoBehaviour
{
    Screenshake screenshakeScript;

    void Start ()
    {
        screenshakeScript = GetComponent<Screenshake>();

    }
	
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Global.me.Reload == true)
            {
                screenshakeScript.SetScreenShake(.2f, 1f, Vector3.right);
            }
    }
}
