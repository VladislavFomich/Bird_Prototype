using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimControl : MonoBehaviour
{
   public PlatformJump platformJump;

   private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (platformJump.isJump == true)
            animator.SetBool("isJump", true);
        else
            animator.SetBool("isJump", false);
    }
}
