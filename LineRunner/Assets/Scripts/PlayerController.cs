using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _playerYPos;


    void Start()
    {
        _playerYPos = transform.position.y;
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _playerYPos = -_playerYPos;
            transform.position = new Vector3(transform.position.x, _playerYPos, 0);
        }
    }
}
