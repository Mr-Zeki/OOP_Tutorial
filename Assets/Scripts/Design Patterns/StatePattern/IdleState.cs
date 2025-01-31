using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IState
{
    public void EnterState(PlayerController1 player)
    {
        //player.animator.SetTrigger("Idle");
        player.animator.SetFloat("Speed", 0f);
        player.animator.SetBool("Jump",false);
        Debug.Log("Entering Idle State");
    }

    public void ExitState(PlayerController1 player)
    {
        Debug.Log("Exiting Idle State");
    }

    public void UpdateState(PlayerController1 player)
    {
        player.animator.SetTrigger("Idle");
        player.HandlePlayerMovement();
        if (player.IsWalking() && player.IsGrounded() )
        {
            player.ChangeState(new WalkingState());
        }
        else if(!player.IsGrounded())
        {
            player.ChangeState(new JumpingState() );
        }
    }
}
