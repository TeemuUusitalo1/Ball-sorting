using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    [SerializeField] Transform[] Points;
    private int pointsIndex;
    private float point = 1f;
    private float point2 = 1f;
    private float point3 = 1f;
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;
    public GameObject Prefab2;
    // Start is called before the first frame update
    void Start()
    {
        point = pointsIndex;
        point2 = pointsIndex;
        point3 = pointsIndex;

        // Vector3 firstPos = positions[firstPosIdx];
        // Vector3 secondPos = positions[1 - firstPosIdx];

        int firstPosIdx = Random.Range(0, 1);

    }

    // Update is called once per frame
    void Update()
    {
        //Randomize object
        float randomChance = Random.Range(0.0f, 1.0f);
        if (randomChance < 0.4f)
        {
            // Instantiate at position
            Instantiate(myPrefab, new Vector3(point2, point3, point), Quaternion.identity);
        }
        else
        {
            Instantiate(Prefab2, new Vector3(19, 24, 18), Quaternion.identity);

        }
    }


}
