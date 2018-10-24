using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour {

    public Transform target;
    public float speed;
    Camera myCam;

	// Use this for initialization
	void Start () {
        myCam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        myCam.orthographicSize = (Screen.height / 100f) / .05f;
        if(target){
            transform.position = Vector3.Lerp(transform.position, target.position, 0.1f) + new Vector3(0,0,-10);
        }
	}
}
