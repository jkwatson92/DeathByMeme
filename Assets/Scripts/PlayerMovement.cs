﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public AudioClip effect;
    public AudioSource effectSource;
    Rigidbody2D rbody;
    Animator anim;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement_V = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (movement_V != Vector2.zero)
        {
            anim.SetBool("Is_walking", true);
            anim.SetFloat("Input_x", movement_V.x);
            anim.SetFloat("Input_y", movement_V.y);
        }
        else
        {
            anim.SetBool("Is_walking", false);
        }

        rbody.MovePosition(rbody.position + movement_V * Time.deltaTime * 70.0f);
        if (Input.GetKeyDown("escape"))
        {
            QuitGame();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        else if(other.gameObject.CompareTag("DoorTrigger"))
        {
            Debug.Log("Player collided");
            effectSource.clip = effect;
            effectSource.Play();
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            Destroy(GameObject.FindGameObjectWithTag("Door"));
        }
        else if(other.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        }
    }



    void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
