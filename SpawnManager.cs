using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public int numberOfEnemiesToSpawn = 3;

    private float spawnZ = 22;
    public int enemyCount;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Obstacle").Length;

        if (enemyCount == 0)
        {
            for (int i = 0; i < numberOfEnemiesToSpawn; i++)
            {

                int randomIndex = Random.Range(0, enemyPrefabs.Length);
                GameObject randomEnemyPrefab = enemyPrefabs[randomIndex];


                Instantiate(randomEnemyPrefab, GenerateSpawnPosition(), randomEnemyPrefab.transform.rotation);
            }
        }
    }

    Vector3 GenerateSpawnPosition()
    {
        float xPos = 24;
        float zPos = Random.Range(spawnZ, -spawnZ);
        return new Vector3(xPos, 0, zPos);
    }
}
