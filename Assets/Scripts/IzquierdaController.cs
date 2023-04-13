using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IzquierdaController : MonoBehaviour
{

    //Pared
    public bool wallJumping = false;

    public bool canJumpWalls()
    {
        if (wallJumping)
        {
            return true;
        }
        return false;
    }

    public void JumpWalls()
    {
        wallJumping = false;
    }

    void OnCollisionStay2D(Collision2D other)
    {
        Debug.Log(other.gameObject.name);
        wallJumping = true;
    }
}
