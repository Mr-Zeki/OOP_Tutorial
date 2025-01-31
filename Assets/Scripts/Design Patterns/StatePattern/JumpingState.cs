using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingState : IState
{
    public void EnterState(PlayerController1 player)
    {
        player.animator.SetBool("Jump", true);
        Debug.Log("Entering Jump State");
    }

    public void ExitState(PlayerController1 player)
    {
        Debug.Log("Exiting Jump State");
    }

    public void UpdateState(PlayerController1 player)
    {
        
        player.HandleJump();
        if (player.IsWalking() && player.IsGrounded())
        {
            player.ChangeState(new WalkingState());
        }
        else if (!player.IsWalking() && player.IsGrounded())
        {
            
            player.ChangeState(new IdleState());
        }
    }
}
