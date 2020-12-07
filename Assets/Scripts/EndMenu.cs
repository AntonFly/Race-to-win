using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndMenu : MonoBehaviour
{
    public Text bestScoreText;
    public Text cureScoreText;

    public void Start()
    {
        bestScoreText.text = "Best score: "+ PlayerPrefs.GetFloat("bestScore");
        cureScoreText.text = "Your score: "+ PlayerPrefs.GetFloat("score");
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}