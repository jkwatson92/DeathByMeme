using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MothAi3 : MonoBehaviour {

    float savedTime;
    Animator anim;

    // Use this for initialization
    void Start()
    {
        savedTime = Time.time;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float counter = Time.time - savedTime;
        if (counter <= 3)
        {
            transform.Translate(Vector3.left * Time.deltaTime * 30f);
            anim.SetBool("MothLeft", true);
        }
        else if (counter > 3 && counter <= 9)
        {
            transform.Translate(Vector3.right * Time.deltaTime * 30f);
            anim.SetBool("MothLeft", false);
            anim.SetBool("MothRight", true);
        }
        else if (counter > 9 && counter <= 12)
        {
            transform.Translate(Vector3.left * Time.deltaTime * 30f);
            anim.SetBool("MothRight", false);
            anim.SetBool("MothLeft", true);
        }
        else if (counter > 12 && counter <= 17)
        {
            transform.Translate(Vector3.down * Time.deltaTime * 40f);
            anim.SetBool("MothLeft", false);
            anim.SetBool("MothDown", true);
        }
        else if(counter >17 && counter <=20)
        {

        }
        else if (counter > 20 && counter <= 25)
        {
            transform.Translate(Vector3.up * Time.deltaTime * 40f);
            anim.SetBool("MothDown", false);
            anim.SetBool("MothUp", true);
        }
        else
        {
            savedTime = Time.time;
            anim.SetBool("MothUp", false);
        }
    }
}
