using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreButton:MonoBehaviour
{
    [SerializeField]private Button scoreButton;
    public int score;
    public Action<int> OnScoreChanged;
    public Action OnClicked;

    private void Awake()
    {
        //null 체크 후 추가하는 방식으로 널 방지가능
        //scoreButton = GetComponentInChildren<Button>(); //필요없음.
        scoreButton.onClick.AddListener(PointUp);
    }

    private void PointUp()
    {
        //OnClicked?.Invoke(); //애니
        score++;
        OnScoreChanged?.Invoke(score); //점수ui
    }
}