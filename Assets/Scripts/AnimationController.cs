using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private int animationVariable = 0;
    private int animationVariableMax = 3;
    [SerializeField] private Button button;



    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        button = GetComponentInChildren<Button>();

    }

    private void Start()
    {
        button.onClick.AddListener(OnMouseDown);
    }

    public void OnMouseDown()
    {
        //animationVariable을 수정
        //처음에 -1로 안움직이기
        //클릭하면 0 아이들
        //클릭하면 1 점프
        //클릭하면 2 공격
        animator.SetInteger("idle", animationVariable);
        animator.SetInteger("doJump", animationVariable);
        animator.SetInteger("doAttack", animationVariable);
        animationVariable++;
        Debug.Log(animationVariable);
        if(animationVariable == animationVariableMax)
        {
            animationVariable = 0;
        }
    }

}
