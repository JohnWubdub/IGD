﻿using UnityEngine;
using System.Collections;

public class Global : MonoBehaviourSingleton<Global> //acts almost like a bank for the global variables to be called later
{
    public static Global me; //instatiates the script
    public int EnemiesKilled = 0; //global variable for winning condition
    public int SonsHit = 0; //global varaible for the losing condition
    public float Timer = 30f; //Timer for each level
    public bool Reload = true; //checks if the player has reloaded

    private void Awake() 
    {
        me = this; //awakens the script
    }
}
