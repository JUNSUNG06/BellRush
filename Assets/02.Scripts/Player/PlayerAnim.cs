using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private Animator animator;
    private PlayerInput playerInput;
    private int runHash = Animator.StringToHash("isRun");
    private int slideHash = Animator.StringToHash("isSlide");
    private int jumpHash = Animator.StringToHash("isJump");

    private void Start()
    {
        animator = GetComponent<Animator>();
        playerInput = GetComponent<PlayerInput>();

        playerInput.jumpAction += JumpAnim;
        playerInput.slideAction += SlideAnim;
    }

    public void SetRunAnim()
    {
        animator.SetBool(runHash, true);
        Debug.Log(1);
    }

    public void SlideAnim()
    {
        animator.SetBool(runHash, false);
        animator.SetTrigger(slideHash);
    }

    public void JumpAnim()
    {
        animator.SetBool(runHash, false);
        animator.SetTrigger(jumpHash);
    }
}
