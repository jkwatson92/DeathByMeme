using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    public float speed;
    private Rigidbody2D rb2d;


    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        DontDestroyOnLoad(rb2d);
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);

    }
        void OnTriggerEnter2D(Collider2D other)
    {
        Scene sceneToLoad = SceneManager.GetSceneByName("GreatRoom");
        SceneManager.LoadScene(sceneToLoad.name, LoadSceneMode.Additive);
        SceneManager.MoveGameObjectToScene(rb2d.gameObject, sceneToLoad);
    }
   
}



