using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingState : IState
{
    public void EnterState(PlayerController1 player)
    {
        
        Debug.Log("Entering Walking State");
    }

    public void ExitState(PlayerController1 player)
    {
        Debug.Log("Exiting Walking State");
    }
    
    public void UpdateState(PlayerController1 player)
    {
        player.animator.SetFloat("Speed", 1f);
        player.HandlePlayerMovement();
        if (!player.IsWalking() || !player.IsGrounded())
        {
            
            player.ChangeState(new IdleState());

        }
        else if (!player.IsGrounded())
        {
            player.ChangeState(new JumpingState());
        }
    }
}
