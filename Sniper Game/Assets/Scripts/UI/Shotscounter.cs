using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shotscounter : MonoBehaviour
{
    Text Counter;

    void Start ()
    {
        Counter = GetComponent<Text>();
    }
	
	
	void Update ()
    {
        Counter.text = "BULLETS USED:" + Global.me.Shots;
    }
}
