using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class Screenflash : MonoBehaviour //deals with the screen flash and blur
{

    public void Flash(float flashTime)
    {
        StartCoroutine(CameraFlash(flashTime));
    }
    public IEnumerator CameraFlash(float flashTime)
    {
        Camera.main.GetComponent<Bloom>().enabled = true;
        Camera.main.GetComponent<Blur>().enabled = true;
        yield return new WaitForSeconds(flashTime);
        Camera.main.GetComponent<Blur>().enabled = false;
        Camera.main.GetComponent<Bloom>().enabled = false;
    }
}