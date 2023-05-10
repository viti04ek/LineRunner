using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] Obstacles;
    public float SpawnRate;

    
    void Start()
    {
        StartCoroutine("SpawnObstacles");
    }


    IEnumerator SpawnObstacles()
    {
        while(true)
        {
            Spawn();
            yield return new WaitForSeconds(SpawnRate);
        }
    }


    void Spawn()
    {
        int randomObstacle = Random.Range(0, Obstacles.Length);
        Instantiate(Obstacles[randomObstacle], transform.position, transform.rotation);
    }
}
