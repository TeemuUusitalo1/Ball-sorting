using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mono.Data.Sqlite;

public class GameCheck : MonoBehaviour
{
    public StartGame startGame;
    public GameObject Red;
    public bool gameOver;
    Animator m_Animator;
    [SerializeField] private Tag _tagCheck;

    private int objectCount = 0; // Counter for the specific objects
    private const int targetCount = 20; // The target number of objects to end the game

    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
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

    // Optional: Reset the counter if an object exits the trigger
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.HasTag(_tagCheck))
        {
            objectCount--; // Decrement the counter
            Debug.Log("Object exited: " + objectCount);
        }
    }

    //Loading EndScreen
    public void EndGame()
    {

        gameOver = true;
        SceneManager.LoadScene("EndScreen");
    }

}
