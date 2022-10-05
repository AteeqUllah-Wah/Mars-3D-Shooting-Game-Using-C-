using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationOFPlayerStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int isRunningHash;

    void Start()
    {
        animator = GetComponent<Animator>();

        // Increase Performance
        isWalkingHash = Animator.StringToHash("IsWalking");
        isRunningHash = Animator.StringToHash("IsRunning");
    }

    void Update()
    {
        bool isrunning = animator.GetBool(isRunningHash);
        bool iswalking = animator.GetBool(isWalkingHash);
        bool forwordPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");

        //If player pressed w key
        if(!iswalking && forwordPressed)
        {
            animator.SetBool(isWalkingHash, true);
        }

        //if player is not pressed w key
        if(iswalking && ! forwordPressed)
        {
            animator.SetBool(isWalkingHash, false);
        }

        //if player is walking and nor running and pressed left shift
        if(!isrunning && (forwordPressed && runPressed))
        {
            animator.SetBool("IsRunning", true);
        }

        //if Player is running and stop running or stop walking
        if (isrunning && (!forwordPressed || !runPressed))
        {
            animator.SetBool("IsRunning", false);
        }
    }
}
