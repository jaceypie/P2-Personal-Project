using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Bad;
    private Vector3 spawnPos;
    private float spawnRangeX= 0.5f;
    private float spawnPosZ = 45;
    private float spawnRangeY= 2;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomPrefab", startDelay, spawnInterval); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomPrefab()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(spawnRangeY, spawnRangeY), spawnPosZ);
        Instantiate(Bad, spawnPos, Bad.transform.rotation);
    }

}
