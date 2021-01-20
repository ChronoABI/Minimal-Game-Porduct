using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnner : MonoBehaviour
{
    [SerializeReference] Transform[] spawnPoints;
    [SerializeReference] GameObject enemy;
    [SerializeReference] float spawnInterval;
    private float nextSpawnTime;
    void Update()
    { 
        if (nextSpawnTime<Time.time)
        {
            int random = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy, spawnPoints[random].position, Quaternion.identity);
            nextSpawnTime = spawnInterval + Time.time;
        }
    }
}
