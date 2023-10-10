
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinState : IPlayerState
{
    public void Enter(Player player)
    {
        player.mCurrentState = new SpinState();
        //player.transform.position = new Vector3(0f, 1.5f, 0f);
        Debug.Log("Entered: Spin State");
    }

    public void Execute(Player player)
    {
        player.GetComponent<Rigidbody>().useGravity = false;
        player.transform.Rotate(0f, 0f, 360f * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.S))
        {
            player.transform.Rotate(0f, 0f, 0f);
            player.GetComponent<Rigidbody>().useGravity = true;
            StandingState standingState = new StandingState();
            standingState.Enter(player);
        }
    }

}