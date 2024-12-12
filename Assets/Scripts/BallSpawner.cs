using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    [SerializeField] Transform[] Points;
    public bool Amount;
    private float ObjectsBlue = 0f;
    private float ObjectsRed = 0f;
    // Reference to the Prefab.
    public GameObject myPrefab;
    public GameObject Prefab2;
    // Start is called before the first frame update
    void Start()
    {
        Amount = true;

    }

    private void SpawnBall()
    {
        while (Amount == true)
        {
           // int RandomColor = Random.Range(0, 3);
            int randomChance = Random.Range(0, 22);
            if (randomChance >= 10)
            {
                Instantiate(myPrefab, new Vector3(20, 24, 22), Quaternion.identity);
                ObjectsBlue++;
            }
            Vector3 spawnPoint = new Vector3(Random.Range(20, 24), 22, Random.Range(0, 0));

            if (randomChance <= 9)
            {
                Instantiate(Prefab2, spawnPoint, Quaternion.identity);
                ObjectsRed++;
            }


            
            if (ObjectsBlue == 10 && ObjectsRed == 10)
            {
                ObjectCount();
            }
        }
    }
    private void ObjectCount()
    {
        Amount = false;
    }
    // Update is called once per frame
    void Update()
    {
        SpawnBall();
    }


}
