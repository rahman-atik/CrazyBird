using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManue : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Ok");
        SceneManager.LoadScene ("GameScene");
        //Debug.Log("Pressed");
    }

    public void update()
    {
        Debug.Log("Working");
    }
}
