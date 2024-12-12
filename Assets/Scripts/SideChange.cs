using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideChange : MonoBehaviour
{
    public BallController ballController;

    public GameObject Corner;

    private List<GameObject> objectsInsideTrigger = new List<GameObject>();



    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Down")&& !objectsInsideTrigger.Contains(other.gameObject))
        {
            objectsInsideTrigger.Add(other.gameObject);
            other.gameObject.tag = "Down(R)";
        }
        if (other.CompareTag("Down(R)") && !objectsInsideTrigger.Contains(other.gameObject))
        {
            objectsInsideTrigger.Add(other.gameObject);
            other.gameObject.tag = "Down";

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (objectsInsideTrigger.Contains(other.gameObject))
        {
            objectsInsideTrigger.Remove(other.gameObject);

        }
    }

}

