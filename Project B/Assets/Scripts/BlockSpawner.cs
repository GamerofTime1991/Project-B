using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject blockPrefab;

    private float timeToSpawn = 2f;
    public float timeBetweenWaves = 1f;
    
    // Start is called before the first frame update
    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            //This sets a timer before spawning more blocks
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
        }

    }

    void SpawnBlocks()
    {
        //the random number generator for said blocks
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }
}
