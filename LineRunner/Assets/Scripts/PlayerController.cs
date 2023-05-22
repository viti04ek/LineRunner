using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _playerYPos;

    public GameObject Particle;


    void Start()
    {
        _playerYPos = transform.position.y;
    }


    void Update()
    {
        if (GameManager.Instance.GameStarted)
        {
            if (!Particle.activeInHierarchy)
                Particle.SetActive(true);

            if (Input.GetMouseButtonDown(0))
            {
                _playerYPos = -_playerYPos;
                transform.position = new Vector3(transform.position.x, _playerYPos, 0);
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            GameManager.Instance.UpdateLives();
            GameManager.Instance.Shake();
        }
    }
}
