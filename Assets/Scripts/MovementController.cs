using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public FootController footController;
    public IzquierdaController izquierdaController;

    //Suelo
    public float jumpForce = 230f;

    //Pared

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && footController.canJump())
        {
            rb.AddForce(transform.up * jumpForce);
            footController.Jump();
        }

        bool jumpVerificar = !footController.canJump() && izquierdaController.canJumpWalls() || footController.canJump() && izquierdaController.canJumpWalls() || footController.canJump() && !izquierdaController.canJumpWalls();
        if (Input.GetKeyUp(KeyCode.Space) && jumpVerificar)
        {
            rb.AddForce(transform.up * (jumpForce));
            izquierdaController.JumpWalls();
        }

    }
}
