using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    Vector3 spawnPos = new Vector3(25,0,0);
    float startDelay = 2f;
    float repeatDelay = 2f;
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);

    }
}
