using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

    public AudioClip background;
    public AudioSource backgroundSource;

    // Use this for initialization
    void Start()
    {
        backgroundSource.clip = background;
        backgroundSource.volume = 0.7f;
        backgroundSource.Play();
    }

}
