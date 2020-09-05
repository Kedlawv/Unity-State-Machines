using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDuckingState : PlayerBaseState
{
    public override void EnterState(PlayerController_FSM player)
    {
        player.head.localPosition = new Vector3(player.head.localPosition.x, 0.5f, player.head.localPosition.z);
        player.SetExpression(player.duckingSprite);
    }

    public override void OnCollisionEnter(PlayerController_FSM player)
    {
        
    }

    public override void Update(PlayerController_FSM player)
    {
        if (Input.GetButtonUp("Duck"))
        {
            player.head.localPosition = new Vector3(player.head.localPosition.x, 0.8f, player.head.localPosition.z);
            player.SetExpression(player.idleSprite);
            player.TransitionToState(player.IdleState);
        }
    }
}
