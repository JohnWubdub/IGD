using UnityEngine;
using System.Collections;

public class SoundManagerScript : MonoBehaviour //manages the sound effects
{
    public AudioClip shootSound; //establishes the shooting sound
    public AudioClip reloadSound; //establishes the reload sound
    private AudioSource source; //establishes the private sound source
    public float volume; // establishes a volume

    void Start ()
    {
        source = GetComponent<AudioSource>(); //initalizes the sound effect

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Global.me.Reload == true) //sees if it can play the sound
        {
            source.PlayOneShot(shootSound, volume); //plays sound effect
            Global.me.Reload = false; //the player needs to reload
        }
        if (Input.GetKeyDown(KeyCode.R)) //checks if the button is pressed
        {
            source.PlayOneShot(reloadSound, volume); //Plays the sound effect
        }

    }
}
