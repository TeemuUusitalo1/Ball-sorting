using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameEnding : MonoBehaviour
{
    [SerializeField] GameObject Red;
    [SerializeField] GameObject Blue;
    public bool Mixed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Checking if Gameobject with tag red is inside trigger if not EndGame
    public void OnTriggerEnter(Collider other)
    {
        if (gameObject == Red)
        {
            Debug.Log("Sort Colored dice");
        }
        else if (gameObject == Blue)
        {
          Invoke("EndGame", 2);
        }


    }

    //Loading EndScreen
    public void EndGame()
    {
        SceneManager.LoadScene("EndScreen");
    }

    
}
