using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persist : MonoBehaviour
{
    private static Persist persist = null;

    public static int sonsHit = 0;

    void Awake()
    {
        if (persist == null)
        {
            DontDestroyOnLoad(this);
            persist = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}