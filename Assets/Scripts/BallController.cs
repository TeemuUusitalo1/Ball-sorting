using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public bool moveLeft;

    // Distance to teleport downwards
    public float moveSpeed = 1.0f; 
    
    [SerializeField] private Tag _tagCheck;
    public CenterSideCheck centerSideCheck;

    public void Start()
    {

    }
    public void Update()
    {
        if (centerSideCheck.GetComponent<CenterSideCheck>().IsLeft == true)
        {
            if (gameObject.tag == "Down")
            {
                if (Input.GetKeyDown(KeyCode.S))
                {
                    transform.position += Vector3.left * Time.deltaTime * moveSpeed;
                }
            }
            if (gameObject.tag == "Left")
            {
                if (Input.GetKeyDown(KeyCode.S))
                {
                    transform.position += Vector3.forward * Time.deltaTime * moveSpeed;
                }
            }
            if (gameObject.tag == "Up")
            {
                if (Input.GetKeyDown(KeyCode.S))
                {
                    transform.position += Vector3.right * Time.deltaTime * moveSpeed;
                }
            }
            if (gameObject.tag == "Right")
            {
                if (Input.GetKeyDown(KeyCode.S))
                {
                    transform.position += Vector3.back * Time.deltaTime * moveSpeed;
                }
            }
        }
        else if (centerSideCheck.GetComponent<CenterSideCheck>().IsLeft == false)
        {
            if (gameObject.tag == "Down(R)")
            {
                if (Input.GetKeyDown(KeyCode.S))
                {
                    transform.position += Vector3.left * Time.deltaTime * moveSpeed;
                }
            }
            if (gameObject.tag == "Left(R)")
            {
                if (Input.GetKeyDown(KeyCode.S))
                {
                    transform.position += Vector3.forward * Time.deltaTime * moveSpeed;
                }
            }
            if (gameObject.tag == "Up(R)")
            {
                if (Input.GetKeyDown(KeyCode.S))
                {
                    transform.position += Vector3.right * Time.deltaTime * moveSpeed;
                }
            }
            if (gameObject.tag == "Right(R)")
            {
                if (Input.GetKeyDown(KeyCode.S))
                {
                    transform.position += Vector3.back * Time.deltaTime * moveSpeed;
                }
            }
        }
    }
        





}






