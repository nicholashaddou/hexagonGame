using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float spawnRate = 1f;
    public GameObject hexagon;
    private float nextSpawn = 0f;
    //private float spawnTimer = 0f;

    void Update()
    {
        //spawnRate = Mathf.Pow(0.9f, Time.timeSinceLevelLoad / 5f);


        if (Time.time >= nextSpawn)
        {
            Instantiate(hexagon, Vector3.zero, Quaternion.identity);
            nextSpawn = Time.time + 1f / spawnRate;
        }

    }
}
