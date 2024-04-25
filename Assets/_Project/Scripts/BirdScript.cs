using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BirdScript : MonoBehaviour
{

    private Rigidbody2D myRigidBody;
    public float flapStrength = 5;
    private LogicScript logic;
    bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {        
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            Jump();
        }

        if (logic.isGameOver)
        {
            myRigidBody.velocity = Vector3.zero;
        }
    }

    public void Jump()
    {
        myRigidBody.velocity = Vector2.up * flapStrength;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
