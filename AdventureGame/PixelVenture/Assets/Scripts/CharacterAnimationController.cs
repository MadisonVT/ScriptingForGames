using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleAnimations();
    }

    private void HandleAnimations()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetTrigger("RunTrigger");

        }
        else
        {
            animator.SetTrigger("IdleTrigger"); 

        }

        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("JumpTrigger");

        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger("WallJumpTrigger");

        }
    }
}
