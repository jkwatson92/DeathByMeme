using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MothAI : MonoBehaviour {
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
        if (counter <= 5)
        {
            transform.Translate(Vector3.up * Time.deltaTime * 60f);
            anim.SetBool("MothUp", true);
        }
        else if (counter > 5 && counter <= 10)
        {
            transform.Translate(Vector3.down * Time.deltaTime * 60f);
            anim.SetBool("MothUp", false);
            anim.SetBool("MothDown", true);
        }
        else if (counter > 10 && counter <= 15)
        {
            transform.Translate(Vector3.left * Time.deltaTime * 25f);
            anim.SetBool("MothDown", false);
            anim.SetBool("MothLeft", true);
        }
        else if (counter > 15 && counter <= 25)
        {
            transform.Translate(Vector3.right * Time.deltaTime * 25f);
            anim.SetBool("MothLeft", false);
            anim.SetBool("MothRight", true);
        }
        else if (counter > 25 && counter <= 30)
        {
            transform.Translate(Vector3.left * Time.deltaTime * 25f);
            anim.SetBool("MothRight", false);
            anim.SetBool("MothLeft", true);
        }
        else
        {
            savedTime = Time.time;
            anim.SetBool("MothLeft", false);
        }
    }
}
