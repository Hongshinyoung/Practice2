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


    public void OnMouseDown(int score) //�Ű����� �־ ����Ƽ Ǯ��
    {
        //animationVariable�� ����

        animator.SetInteger("idle", animationVariable);
        animator.SetInteger("doJump", animationVariable);
        animator.SetInteger("doAttack", animationVariable);

        //%�̿��ؼ� 1�ٷ� ���̱�
        animationVariable++;

        if(animationVariable >= animationVariableMax) // ==���� �̰� �� �����
        {
            animationVariable = 0;
        }
        
    }

}
