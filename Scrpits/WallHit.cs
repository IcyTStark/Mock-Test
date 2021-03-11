using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHit : MonoBehaviour
{
    PlayerMovement player;
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
    }
    
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.name == "BOXO")
        {
            player.Health += 0.5f;
        }
    }
}
