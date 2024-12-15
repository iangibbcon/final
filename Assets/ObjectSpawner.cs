using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [Header("Objects to Spawn")]
    public GameObject[] objectsToSpawn; // array for objects

    [Header("Spawn Points")]
    public Transform[] spawnPoints;     // array for the spawn points themself

    [Header("Spawn Settings")]
    public float spawnInterval = 2f;    // cooldown
    void Start()
    {
        // start it
        InvokeRepeating(nameof(SpawnObject), 0f, spawnInterval);
    }

    void SpawnObject()
    {
        if (objectsToSpawn.Length == 0 || spawnPoints.Length == 0)
        {
            Debug.LogWarning("nothing assigned!");
            return;
        }

        // pick a random object and a random spawn point
        GameObject objectToSpawn = objectsToSpawn[Random.Range(0, objectsToSpawn.Length)];
        Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

        // instantiate the object at the chosen spawn point
        Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
    }
}
