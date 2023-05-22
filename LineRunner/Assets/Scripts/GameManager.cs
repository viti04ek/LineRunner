using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool GameStarted = false;
    public GameObject Player;

    private int _lives = 2;
    private int _score = 0;

    public Text ScoreText;
    public Text LivesText;

    public GameObject MenuUI;
    public GameObject GamePlayUI;
    public GameObject Spawner;

    public GameObject BackgroundParticle;

    private Vector3 _originalCameraPos;


    private void Awake()
    {
        Instance = this;
    }


    private void Start()
    {
        _originalCameraPos = Camera.main.transform.position;
    }


    public void StartGame()
    {
        GameStarted = true;
        MenuUI.SetActive(false);
        GamePlayUI.SetActive(true);
        Spawner.SetActive(true);
        BackgroundParticle.SetActive(true);
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
        LivesText.text = $"Lives: {_lives}";

        if (_lives <= 0)
            GameOver();
    }


    public void UpdateScore()
    {
        _score++;
        ScoreText.text = $"Score: {_score}";
    }


    public void ExitGame()
    {
        Application.Quit();
    }


    public void Shake()
    {
        StartCoroutine("CameraShake");
    }


    IEnumerator CameraShake()
    {
        for (int i = 0; i < 5; i++)
        {
            Vector2 randomPos = Random.insideUnitCircle * 0.5f;
            Camera.main.transform.position = new Vector3(randomPos.x, randomPos.y, _originalCameraPos.z);
            yield return null;
        }

        Camera.main.transform.position = _originalCameraPos;
    }
}
