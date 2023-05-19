using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject[] fishPrefabs;
    public Vector3 minBounds;
    public Vector3 maxBounds;
    public int fishCount = 10;

    void Start()
    {
        for (int i = 0; i < fishCount; i++)
        {
            Vector3 position = new Vector3(
                Random.Range(minBounds.x, maxBounds.x),
                Random.Range(minBounds.y, maxBounds.y),
                Random.Range(minBounds.z, maxBounds.z)
            );
            GameObject fishPrefab = fishPrefabs[Random.Range(0, fishPrefabs.Length)];
            GameObject fish = Instantiate(fishPrefab, position, Quaternion.identity);
            Fish fishScript = fish.GetComponent<Fish>();
            fishScript.minBounds = minBounds;
            fishScript.maxBounds = maxBounds;
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube((minBounds + maxBounds) / 2f, maxBounds - minBounds);
    }
}
