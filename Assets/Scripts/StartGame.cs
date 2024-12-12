using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartGame : MonoBehaviour
{
   public bool timerActive = false;

    private void Start()
    {
        timerActive = false;
    }
    void Update()
    {
        
    }

    public void StartButton()
    {
        //Load GameScene when pressed
        SceneManager.LoadScene("GameScene");
    }

    public void timerButton()
    {
        timerActive = true;
    }
}
