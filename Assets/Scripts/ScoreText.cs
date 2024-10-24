using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText:MonoBehaviour
{
    public ScoreButton scoreBtn;
    public TextMeshProUGUI scoreText;


    private void Awake()
    {
        //scoreText = GetComponentInChildren<TextMeshProUGUI>();
        scoreBtn.OnScoreChanged += RefreshUI;
    }

    private  void RefreshUI(int newScore)
    {
        scoreText.text = newScore.ToString();
    }

}