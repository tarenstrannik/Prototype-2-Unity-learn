using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnRangeX = 10f;
    private float spawnPosZ = 20f;
    private float spawnPosXLeft = -15f;
    private float spawnPosXRight = 15f;

    private float spawnRangeZMin = 0f;
    private float spawnRangeZMax = 15f;

    private float startDelay = 2f;
    private float spawnInterval = 1.5f;
    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }
    void SpawnRandomAnimal()
    {
        int randCase = Random.Range(0, 4);

        if (randCase == 0)
        {


            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
        else if (randCase==1)
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(spawnPosXLeft, 0, Random.Range(spawnRangeZMin, spawnRangeZMax));
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation * Quaternion.Euler(0f, -90f, 0f));
        }
        else if(randCase==2)
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(spawnPosXRight, 0, Random.Range(spawnRangeZMin, spawnRangeZMax));
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation * Quaternion.Euler(0f, 90f, 0f));
        }
    }
}
