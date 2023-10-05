using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;

    public void Start()
    {
        int amount = 1000;

        // Create an array of random points within a sphere.
        Vector3[] randomPoints = new Vector3[amount];
        for (int i = 0; i < randomPoints.Length; i++)
        {
            // generate a random points within a range of -10 to 10
            randomPoints[i] = new Vector3(
                UnityEngine.Random.Range(100, 800),
                500,
                UnityEngine.Random.Range(100, 800)
            );
        }

        // Spawn coins
        for (int i = 0; i < randomPoints.Length; i++)
        {
            Instantiate(coinPrefab, randomPoints[i], Quaternion.identity);
        }
    }
}
