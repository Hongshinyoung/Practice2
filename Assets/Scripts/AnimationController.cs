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
        //animationVariable�� ����
        //ó���� -1�� �ȿ����̱�
        //Ŭ���ϸ� 0 ���̵�
        //Ŭ���ϸ� 1 ����
        //Ŭ���ϸ� 2 ����
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
