﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButtons : MonoBehaviour {
    public bool mainMenu;
    public bool reset;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("escape"))
        {
            QuitGame();
        }

    }
    public void OnMouseUp()
    {
        if (mainMenu)
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
        if (reset)
        {
            SceneManager.LoadScene(1, LoadSceneMode.Single);
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
