using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterSideCheck : MonoBehaviour
{
    public bool IsLeft;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //When center is left IsLeft = true.
    void OnTriggerEnter(Collider collider)
    {
        IsLeft = true;
        Debug.Log("Is left");
    }
    //When center is right IsLeft = false.
    private void OnTriggerExit(Collider other)
    {
        IsLeft = false;
        Debug.Log("Is right");
    }

}
