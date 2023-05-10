using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("Game");
        }
    }
}
