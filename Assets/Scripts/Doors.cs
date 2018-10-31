using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Doors : MonoBehaviour {

    public GameObject triggerObj;
    public GameObject thisDoor;
    // Use this for initialization
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if(!triggerObj){
            Destroy(thisDoor);
        }
    }



}
