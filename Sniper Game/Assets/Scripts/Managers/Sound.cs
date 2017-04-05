using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour //manages the sound effects and plays them
{
    public AudioClip shootSound; //establishes the shooting sound
    public AudioClip reloadSound; //establishes the reload sound
    public AudioClip backSound; //establishes the background music
    //private AudioSource source; //establishes the private sound source
    public float volume; // establishes a volume
    public float backvolume = .5f; //bachground volume

    private AudioSource[] audSources; //creates an array of audio sources
    public GameObject audSource; //assign the game object as being the game object 

    void Start()
    {
        //source = GetComponent<AudioSource>(); //initalizes the sound effect
        audSources = new AudioSource[32]; //32, why? Fuck you that's why
        for (int i = 0; i < audSources.Length; i++) //for loop that create 32 gameobjects that have an audio source attached to it
        {
            audSources[i] = (Instantiate(audSource, Vector3.zero, Quaternion.identity) as GameObject).GetComponent<AudioSource>();
        }
        audSources[0].PlayOneShot(backSound, backvolume); //assigns the background music to the first audio source
    }

    public void Gunshot()
    {
       audSources[1].PlayOneShot(shootSound, volume); //plays sound on the assigned gameobject with the source
    }

    public void Reload()
    {
       audSources[2].PlayOneShot(reloadSound, volume); //plays sound on the assigned gameobject with the source
    }
}
        

