using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootController : MonoBehaviour
{

    //Suelo
    public const int MAX_JUMPS = 7;

    private bool onGround = false;

    private int currentJumps = 0;

    //Pared
    public bool wallJumping = false;
    private int wallJumps = 0;

    //Suelo
    public bool canJump(){ 
        Debug.Log(onGround);
        Debug.Log(currentJumps);
        return onGround || (!onGround && currentJumps < MAX_JUMPS);

    }

    public void Jump()
    {
        currentJumps++;
        onGround = false;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.gameObject.name);
        onGround = true;
        currentJumps = 0;
    }

    //Pared
    public bool canJumpWalls()
    {
        Debug.Log(onGround);
        Debug.Log(wallJumps);
        return onGround || (!onGround && wallJumps < MAX_JUMPS);

    }

    public void JumpWalls()
    {
        wallJumps++;
        wallJumping = false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name);
        wallJumping = true;
    }
}
