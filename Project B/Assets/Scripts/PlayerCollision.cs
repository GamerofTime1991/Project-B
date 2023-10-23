using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            //set up so the blocks can actually do something other than bonk the player
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
