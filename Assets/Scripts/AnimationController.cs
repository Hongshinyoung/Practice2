using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private int animationVariable = 0;
    private int animationVariableMax = 3;
    public ScoreButton scoreButton;
    private void Awake()
    {
        //animator = GetComponentInChildren<Animator>();
        scoreButton.OnScoreChanged += OnMouseDown;
    }


    public void OnMouseDown(int score) //매개변수 주어서 유니티 풀림
    {
        //animationVariable을 수정

        animator.SetInteger("idle", animationVariable);
        animator.SetInteger("doJump", animationVariable);
        animator.SetInteger("doAttack", animationVariable);

        //%이용해서 1줄로 줄이기
        animationVariable++;

        if(animationVariable >= animationVariableMax) // ==보다 이게 더 방어적
        {
            animationVariable = 0;
        }
        
    }

}
