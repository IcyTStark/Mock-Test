using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    private float xValue = 0.1f;
    public float Health = 100f;
    [Tooltip("Defines the speed of the player")]
    [SerializeField] float playerSpeed=1f;

    private Rigidbody2D rb;
    public Level_Manager level;
   

    void Start()
    {
        playerInstruction(); // Calls the playerInstructions() 
        Health = 70f;
        rb = GetComponent<Rigidbody2D>();
        level = FindObjectOfType<Level_Manager>();
       
    }

    private void playerInstruction() //Logs all the information about the game (For Development Purpose)
    {
        Debug.Log("Welcome to the Game.");
        Debug.Log("Tapping Space pushes you Up");
        Debug.Log("Do not collect Health");
        Debug.Log("Instead Collect Spike");
    }

    // Update is called once per frame
    void Update()
    {
        playerMechanics(); //Calling the player Mechanics
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * playerSpeed; //Pushes The player up
        }
        if(Health >= 100) //If Player Health is 100 Loads the Game over scene
        {
            //level.GameOver();
            SceneManager.LoadScene(3);
        }
        //if(Health == 0) //Everytime he reaches health 0 He gets a small speed boost
        //{
        //    playerSpeed += 0.005f;
        //}
       
    }

    void playerMechanics()
    {
        xValue = Time.deltaTime * playerSpeed;
        transform.Translate(xValue, 0f, 0f); //Keeps Moving in X-Direction
    }


}
