using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool GameStarted = false;
    public GameObject Player;

    private int _lives = 2;
    private int _score = 0;


    private void Awake()
    {
        Instance = this;
    }


    public void StartGame()
    {
        GameStarted = true;
    }


    public void GameOver()
    {
        Player.SetActive(false);
        Invoke("ReloadLevel", 1.5f);
    }


    public void ReloadLevel()
    {
        SceneManager.LoadScene("Game");
    }


    public void UpdateLives()
    {
        _lives--;

        if (_lives <= 0)
            GameOver();
    }


    public void UpdateScore()
    {
        _score++;
    }
}
