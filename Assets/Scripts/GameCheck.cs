using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mono.Data.Sqlite;

public class GameCheck : MonoBehaviour
{
    public StartGame startGame;
    public Timer timer;
    public GameObject Red;
    public bool gameOver;
    Animator m_Animator;
    [SerializeField] private Tag _tagCheck;
    
    // Counter for the specific objects
    private int objectCount = 0; 

    // The target number of objects to end the game
    private const int targetCount = 20; 

    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        gameOver = false;
    }

    void Update()
    {

    }


    //Checking if Gameobject with tag red is inside trigger if not EndGame
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object has the correct tag
        if (other.gameObject.HasTag(_tagCheck))
        {
            objectCount++; // Increment the counter
            Debug.Log("Object entered: " + objectCount);

            // Check if we have reached the target count
            if (objectCount >= targetCount)
            {
                startGame.GetComponent<StartGame>().timerActive = true;
                m_Animator.SetTrigger("Ending");
                Invoke("EndGame", 7);
            }
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.HasTag(_tagCheck))
        {
            objectCount--; // Decrement the counter
            Debug.Log("Object exited: " + objectCount);
        }
    }

    //Loading EndScene
    public void EndGame()
    {
        timer.GetComponent<Timer>().InsertTime();
        gameOver = true;
        SceneManager.LoadScene("EndScreen");
    }

}
