using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornenrCheck : MonoBehaviour
{
    public BallController ballController;
    public CenterSideCheck centerSideCheck;

    public GameObject Corner;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // checks gameobjects tag and changes accordingly
    public void OnTriggerEnter(Collider other)
    {
        if (centerSideCheck.GetComponent<CenterSideCheck>().IsLeft == true)
        {
            if (other.CompareTag("Down") && Corner.CompareTag("Left"))
            {
                other.gameObject.tag = "Left";

            }
            if (other.CompareTag("Left") && Corner.CompareTag("Up"))
            {
                other.gameObject.tag = "Up";
            }
            if (other.CompareTag("Up") && Corner.CompareTag("Right"))
            {
                other.gameObject.tag = "Right";
            }
            if (other.CompareTag("Right") && Corner.CompareTag("Down"))
            {
                other.gameObject.tag = "Down";

            }
        }
        else if (centerSideCheck.GetComponent<CenterSideCheck>().IsLeft == false)
        {
            if (other.CompareTag("Down(R)") && Corner.CompareTag("Right(R)"))
            {
                other.gameObject.tag = "Right(R)";

            }
            if (other.CompareTag("Left(R)") && Corner.CompareTag("Down(R)"))
            {
                other.gameObject.tag = "Down(R)";
            }
            if (other.CompareTag("Up(R)") && Corner.CompareTag("Left(R)"))
            {
                other.gameObject.tag = "Left(R)";
            }
            if (other.CompareTag("Right(R)") && Corner.CompareTag("Up(R)"))
            {
                other.gameObject.tag = "Up(R)";

            }
        }


    }


}
