using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAudio : MonoBehaviour
{
    public AudioClip effect;
    public AudioSource effectSource;


    public void onHover()
    {
        effectSource.clip = effect;
        effectSource.Play();
    }
}