using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GirlController : MonoBehaviour
{
    Animator animator;
    private Rigidbody2D rb;
    SpriteRenderer sr;

    private int currentAnimation = 1;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        currentAnimation = 1;
        var velocityY = rb.velocity.y;
        rb.velocity = new Vector2(0, velocityY);

        if (Input.GetKey("d"))
        {
            currentAnimation = 2;
            rb.velocity = new Vector2(2, velocityY);
            sr.flipX = false;
        }
        if (Input.GetKey("a"))
        {
            currentAnimation = 2;
            rb.velocity = new Vector2(-2, velocityY);
            sr.flipX = true;
        }
        if (Input.GetKey("q"))
        {
            currentAnimation = 3;
        }
        if (Input.GetKey("e"))
        {
            currentAnimation = 4;
        }
        if (Input.GetKey("z"))
        {
            currentAnimation = 5;
        }
        if (Input.GetKey("v"))
        {
            currentAnimation = 6;
        }
        animator.SetInteger("Estado", currentAnimation);
    }
}