using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
		 * Fox Weyouth
		 * Prototype 2
		 * Assignment 3
		 * This script spawns the animals from an array of game objects and randomly picks the animal and position.
		 */
public class SpawnManager : MonoBehaviour
{

    public GameObject[] prefabsToSpawn;

    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnPosZ = 20;

    public bool gameOver = false;
   /*void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomPrefab();
        }
    }
   */

    void Start()
    {
        //InvokeRepeating("SpawnRandomPrefab", 2, 1.5f);

        StartCoroutine(SpawnRandomPrefabWithCoroutine());
    }

    IEnumerator SpawnRandomPrefabWithCoroutine()
    {
        yield return new WaitForSeconds(3f);

        while (!gameOver)
        {
            SpawnRandomPrefab();

            float randomDelay = Random.Range(1.5f, 2.0f);

            yield return new WaitForSeconds(randomDelay);
        }
    }

    void SpawnRandomPrefab()
    {
        int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);

        Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);
    }
    
    
}
