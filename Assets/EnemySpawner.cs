using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject objectToSpawn; // Reference to the object you want to spawn.
    public float spawnInterval = 2f; // Time interval in seconds between spawns.

    private void Start()
    {
        // Start the spawning process.
        StartCoroutine(SpawnObjects());
    }

    private IEnumerator SpawnObjects()
    {
        while (true) // Continue spawning indefinitely.
        {
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
            
            // Wait for the specified interval before spawning the next object.
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}