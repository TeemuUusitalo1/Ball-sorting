using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public GameObject destination;
    [SerializeField] private float moveSpeed;
   // private int pointsIndex;
    private Rigidbody rb;

    public float TurningSpeed = 1f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Vector3 lookPos = destination.transform.position - transform.position;
        lookPos.y = 0;
        Quaternion rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * TurningSpeed);

        rb.velocity = transform.forward * moveSpeed;

    }
}





