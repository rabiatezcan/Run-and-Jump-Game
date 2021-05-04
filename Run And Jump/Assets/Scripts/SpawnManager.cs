using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    Vector3 spawnPos = new Vector3(25,0,0);
    float startDelay = 2f;
    float repeatDelay = 2f;
    private PlayerController playerControllerScript; 
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatDelay);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObstacle()
    {
        if (!playerControllerScript.isGameOver)
        { 
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
       

    }
}
