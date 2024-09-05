using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] Transform[] Points;

    [SerializeField] private float moveSpeed;

    private int pointsIndex;
    // Start is called before the first frame update
    void Start()
    {
        //
        transform.position = Points[pointsIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Moving "Balls" Between Points when pressing w or s
        if (pointsIndex <= Points.Length - 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, Points[pointsIndex].transform.position, moveSpeed * Time.deltaTime);


                if (transform.position == Points[pointsIndex].transform.position)
                {
                    pointsIndex = +1;
                }
            
            if (Input.GetKeyDown(KeyCode.S))
            {
                pointsIndex = 0;
            }

        }

    }
}
