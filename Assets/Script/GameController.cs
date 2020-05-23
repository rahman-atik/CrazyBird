using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public static GameController Instance;

    public float scrollSpeed = 1f;
    public bool isGameOver = false;
    private int score = 0;

    public Text scoreText;
    public GameObject gameOverText;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if(isGameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            SceneManager.LoadScene ("MainManue");
        }
    }

    public void Score()
    {
        if(isGameOver) 
        { 
            return; 
        }

        score++;
        scoreText.text = "Score: " + score;
    }

    public void Die()
    {
        gameOverText.SetActive(true);
        isGameOver = true;

    }
}
