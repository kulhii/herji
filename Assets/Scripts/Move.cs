using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 4;
    private Animator animator;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;


    private float moveInput;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(moveInput * movementSpeed, rb.velocity.y);
        animator.SetBool("walk", moveInput != 0);
        if (moveInput != 0)
        {
            spriteRenderer.flipX = moveInput < 0;
        }
    }



    private void OnMove(InputValue value)
    {
        moveInput = value.Get<float>();
    }


}
