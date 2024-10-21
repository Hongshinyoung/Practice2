using System;
using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    private int animationVariable = 0;
    [SerializeField] private Button button;
    public event Action OnAnimationStart;


    private void Awake()
    {
        animator = GetComponent<Animator>();
        button = GetComponent<Button>();
        
    }

    private void Start()
    {
        OnAnimationStart += OnMouseDown;
    }

    private void OnMouseDown()
    {
        
        // animationVariable을 수정
        animator.SetInteger("State", animationVariable);
        animationVariable++;
        Debug.Log("마우스클릭");
    }

    private void OnButtonClick()
    {
        button.onClick.Invoke();
    }
}
