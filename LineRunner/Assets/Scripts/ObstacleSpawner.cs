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
        float randomSpot = Random.Range(0f, 2f);

        if (randomSpot < 1)
        {
            Instantiate(Obstacles[randomObstacle], transform.position, transform.rotation);
        }
        else
        {
            Instantiate(Obstacles[randomObstacle], 
                        new Vector3(transform.position.x, -transform.position.y, transform.position.z), 
                        Quaternion.Euler(0, 0, 180));
        }
    }
}
