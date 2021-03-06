using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [Tooltip("Determines the speed the health sprites are coming")]
    [SerializeField] float speed = 10f;
    Rigidbody2D rb;
    PlayerMovement player;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        player = FindObjectOfType<PlayerMovement>();

        
    }
   
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "BOXO")
        {
            player.Health += 10;
            Destroy(this.gameObject);
        }
    }
}
