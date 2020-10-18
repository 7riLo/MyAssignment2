/*
 * Levi Wyant
 * Prototype 2
 * Make sure prefabs (enemies and items) spawn
 * when required.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class SpawnManager : MonoBehaviour
{
    //Drag the prefabs to spawn onto this array in the inspector
    public GameObject[] prefabsToSpawn;

    //(for step3) Variable for Spawn Position
    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnPosZ = 20;

    public HealthSystem healthSystem;

    public bool gameOver = false;

    void Start()
    {
        //get ref to health system script
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();

        //InvokeRepeating("SpawnRandomPrefab", 2, 1.5f);
        StartCoroutine(SpawnRandomPrefabWithCoroutine());

    }

    IEnumerator SpawnRandomPrefabWithCoroutine()
    {
        yield return new WaitForSeconds(3f);

        while (!healthSystem.gameOver)
        {
            SpawnRandomPrefab();

            float randomDelay = Random.Range(0.8f, 2.0f);
            //This waits for 1.5 seconds before continuing the while loop
            yield return new WaitForSeconds(randomDelay);
        }
    }

    void SpawnRandomPrefab()
    {
        //Prick a random index between 0 and the length of the array
        int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);

        //spawn the randomly selected prefab
        Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);
    }
}
