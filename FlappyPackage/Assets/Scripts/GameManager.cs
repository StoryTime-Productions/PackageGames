using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager _instance;

    [SerializeField] private GameObject _gameOverCanvas;
    [SerializeField] private GameObject _initialCanvas;
    [SerializeField] private GameObject _scoreCanvas;


    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }

        if (SceneManager.GetActiveScene().buildIndex == 0) Time.timeScale = 0f;
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void BeginGame()
    {
        Debug.Log("Hi");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GameOver()
    {
        _scoreCanvas.SetActive(false);

        _gameOverCanvas.SetActive(true);

        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
