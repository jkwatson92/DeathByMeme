using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour {

    Animator anim;
    bool isFading = true;
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
    }

    public void Lightning2()
    {
        isFading = true;
        anim.SetTrigger("lightning2");
    }

    void ChooseLightning(){
        randomLightning = Random.Range(0, 1);

        switch (randomLightning)
        {
            case 0:
                Lightning1();
                break;
            case 1:
                Lightning2();
                break;
            default:
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
