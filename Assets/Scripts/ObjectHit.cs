using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour {

    public AudioClip HitNoise;
    AudioSource HitSource;

    // Use this for initialization
    void Start() {
        HitSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        HitSource.PlayOneShot(HitNoise, 1F);
    }
}
