using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float MoveSpeed;


    void Start()
    {
        
    }


    void Update()
    {
        transform.position += Vector3.left * MoveSpeed * Time.deltaTime;

        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}
