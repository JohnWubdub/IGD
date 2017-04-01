using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour //manages the sound effects
{
    public AudioClip shootSound; //establishes the shooting sound
    public AudioClip reloadSound; //establishes the reload sound
    public AudioClip backSound;
    //private AudioSource source; //establishes the private sound source
    public float volume; // establishes a volume

    private AudioSource[] audSources;
    public GameObject audSource;

    void Start()
    {
        //source = GetComponent<AudioSource>(); //initalizes the sound effect
        audSources = new AudioSource[32];
        for (int i = 0; i < audSources.Length; i++)
        {
            audSources[i] = (Instantiate(audSource, Vector3.zero, Quaternion.identity) as GameObject).GetComponent<AudioSource>();
        }
        audSources[0].PlayOneShot(backSound, volume);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && Global.me.Reload == true) //sees if it can play the sound
        {
            audSources[1].PlayOneShot(shootSound, volume); //plays sound effect
            Global.me.Reload = false; //the player needs to reload
        }
        if (Input.GetKeyDown(KeyCode.R)) //checks if the button is pressed
        {
            audSources[2].PlayOneShot(reloadSound, volume); //Plays the sound effect
        }
    }
}
        

