using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour //manages the sound array and plays the sounds
{
    //audio clips
    public AudioClip shootSound; 
    public AudioClip reload1Sound;
    public AudioClip reload2Sound;
    public AudioClip reload3Sound;
    public AudioClip backSound; 
    public AudioClip drySound; 
    
    public float volume; 
    public float backvolume = .5f; 

    //array and audio source
    private AudioSource[] audSources; 
    public GameObject audSource; 

    
    void Start() //Creates an array of game objects and assigns aduio sources to the game objects
    {
        audSources = new AudioSource[32]; //32, why? Fuck you that's why
        for (int i = 0; i < audSources.Length; i++) 
        {
            audSources[i] = (Instantiate(audSource, Vector3.zero, Quaternion.identity) as GameObject).GetComponent<AudioSource>();
        }
        audSources[0].PlayOneShot(backSound, backvolume); //background music
    }

    //plays sound on the assigned game object
    public void Gunshot() 
    {
       audSources[1].PlayOneShot(shootSound, volume); 
    }

    public void Reload1()
    {
       audSources[2].PlayOneShot(reload1Sound, volume); 
    }
    public void Reload2()
    {
        audSources[3].PlayOneShot(reload2Sound, volume);
    }
    public void Reload3()
    {
        audSources[4].PlayOneShot(reload3Sound, volume);
    }
    public void DryFire()
    {
       audSources[5].PlayOneShot(drySound, volume); 
    }
}
        

