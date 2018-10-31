using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomEffects : MonoBehaviour {
    public AudioClip Effect1;
    public AudioClip Effect2;
    public AudioClip Effect3;
    public AudioClip Effect4;
    public AudioClip Effect5;
    public AudioClip Effect6;
    public AudioSource EffectSource;

    private int randomEffect;
    private float randomTime = 20.0f;
    private float timeCounter;

    // Use this for initialization
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        //Generates a random time to play another effect at
        if(timeCounter > randomTime){
            randomTime = Random.Range(15.0f, 50.0f);
            timeCounter = 0.0f;
            EffectSource.volume = 1;
            EffectSource.Stop();
            ChooseEffect();
            EffectSource.Play();
        }
        timeCounter += Time.deltaTime;
        //Debug.Log("Time: " + timeCounter + " Random Time: "+randomTime);
    }
   void ChooseEffect(){

        //Chooses between 0-3 for a random effect to play at a random time
        randomEffect = Random.Range(0, 5);

        switch(randomEffect){
            case 0:
                EffectSource.clip = Effect1;
                break;

            case 1:
                EffectSource.clip = Effect2;
                break;

            case 2:
                EffectSource.clip = Effect3;
                break;

            case 3:
                EffectSource.clip = Effect4;
                break;

            case 4:
                EffectSource.clip = Effect5;
                break;

            case 5:
                EffectSource.clip = Effect6;
                break;
        }




    }
}
