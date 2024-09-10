using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    [SerializeField] Transform[] Points;
    private int Spawnpoints;
    private int Objects;
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;
    public GameObject Prefab2;
    // Start is called before the first frame update
    void Start()
    {

        //Randomize object

        SpawnBall();

        // Vector3 firstPos = positions[firstPosIdx];
        // Vector3 secondPos = positions[1 - firstPosIdx];

       // int firstPosIdx = Random.Range(0, 1);

    }

    private void SpawnBall()
    {
        int Objects = 0;
        int RandomColor = Random.Range(0, 3);
        int randomChance = Random.Range(0, 22);
        while (Objects < 20)
        {
            if (randomChance == 1 && RandomColor == 1)
            {
                // Instantiate at position
                Instantiate(myPrefab, new Vector3(20, 24, 22), Quaternion.identity);
                Objects = +1;
            }
            if (randomChance >= 2 && RandomColor == 2)
            {
                Instantiate(Prefab2, new Vector3(19, 24, 22), Quaternion.identity);
                Objects = +1;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }


}
