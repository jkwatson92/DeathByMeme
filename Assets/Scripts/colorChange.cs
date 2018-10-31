using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorChange : MonoBehaviour {

    public Text text;
    float interval = 0.20f;
    float timer = 0.0f;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer >= interval){
            if (text.color == Color.red)
            {
                text.color = Color.black;
            }
            else
            {
                text.color = Color.red;
            }
            timer = 0.0f;
        }
	}
}
