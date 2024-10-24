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
        //null üũ �� �߰��ϴ� ������� �� ��������
        //scoreButton = GetComponentInChildren<Button>(); //�ʿ����.
        scoreButton.onClick.AddListener(PointUp);
    }

    private void PointUp()
    {
        //OnClicked?.Invoke(); //�ִ�
        score++;
        OnScoreChanged?.Invoke(score); //����ui
    }
}