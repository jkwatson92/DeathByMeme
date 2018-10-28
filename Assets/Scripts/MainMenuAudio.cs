using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuAudio : MonoBehaviour {
    public AudioClip background;
    public AudioSource backgroundSource;

    // Use this for initialization
    void Start()
    {
        backgroundSource.clip = background;
        backgroundSource.Play();
    }
    
}