using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sonscounter : MonoBehaviour
{
    Text Counter;

    void Start ()
    {
        Counter = GetComponent<Text>();
    }
	
	void Update ()
    {
        Counter.text = "SONS MURDERED:" + Persist.sonsHit;
    }
}
