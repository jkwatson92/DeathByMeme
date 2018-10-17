using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour {

    Animator anim;
    bool isFading = false;
    //bool isStorming = true;
    private int randomLightning;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}
	
    public void AnimationComplete(){
        isFading = false;
    }

    public void Lightning1()
    {
        isFading = true;
        anim.SetTrigger("lightning1");
        while (isFading)
        {
        }
    }

    public void Lightning2()
    {
        isFading = true;
        anim.SetTrigger("lightning2");
        while (isFading)
        {

        }
    }

    void ChooseLightning(){
        randomLightning = Random.Range(0, 1);

        switch (randomLightning)
        {
            case 0:
                Lightning2();
                break;
            case 1:
                Lightning1();
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!isFading)
        {
                ChooseLightning();
        }
    }
}
