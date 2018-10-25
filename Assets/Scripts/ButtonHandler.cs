using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ButtonHandler : MonoBehaviour
{
    public bool isStart;
    public bool isQuit;
    public Text buttonText;
    // Use this for initialization
    void Start()
    {

    }
    public void onHover()
    {
        buttonText.color = Color.blue;
    }

    public void OnMouseExit()
    {
        buttonText.color = Color.red;
    }


    public void OnMouseUp()
    {
        if(isStart){
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
        if(isQuit){
            Application.Quit();
        }
    }



}