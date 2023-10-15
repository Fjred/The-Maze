using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;

    public int coinCount;
    void Start()
    {
        for (int i = 0; i < coinCount; i++)
        {
            var x = Random.Range(-32.5f, 32.5f);
            var z = Random.Range(-32.5f, 32.5f);

            var spawnPosition = new Vector3(x, 1.85f, z);
            Instantiate(coinPrefab, spawnPosition, Quaternion.Euler(new Vector3(90, 0, 0)));
        }
    }
    void Update()
    {
        
    }
}
 