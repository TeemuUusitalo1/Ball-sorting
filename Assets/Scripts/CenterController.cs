using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterController : MonoBehaviour
{
    [SerializeField] Transform[] Points;

    [SerializeField] private float moveSpeed;

    private int pointsIndex;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Points[pointsIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //From youtube but edited so it is controlled by A & D.
        //Moving "Center" Between Points (L & R) when pressing A or D.
        if(pointsIndex <= Points.Length -1)
        {
            transform.position = Vector3.MoveTowards(transform.position, Points[pointsIndex].transform.position, moveSpeed * Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.D))
            {
                if (transform.position == Points[pointsIndex].transform.position)
                {
                    pointsIndex = 1;
                }
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                    pointsIndex = 0;
            }

        }

    }
    // Testing




}
