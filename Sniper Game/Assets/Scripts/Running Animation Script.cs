using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningAnimationScript : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;
	
	void Start ()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
	}
	
	
	void Update ()
    {

        anim.SetFloat("speed", 10);
	}
}
