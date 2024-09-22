using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
   public bool timerActive = false;
    // Update is called once per frame
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
