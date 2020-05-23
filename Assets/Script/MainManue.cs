using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManue : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("working");
        SceneManager.LoadScene ("GameScene");
    }

    public void Home()
    {
        Debug.Log("Working");
        SceneManager.LoadScene ("MainManue");
    }
}
