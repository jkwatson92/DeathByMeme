using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ButtonHandler : MonoBehaviour
{
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

    public void startGame()
    {
        SceneManager.LoadScene("First Floor", LoadSceneMode.Single);
    }
    public void quitGame()
    {
        Application.Quit();
    }


}