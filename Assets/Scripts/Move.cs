using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Android.LowLevel;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 4;
    private Animator animator;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Vector3 inicio;

    private float moveInput;
   
  
    void Start()
    {
        inicio = transform.position;
        Cursor.lockState = CursorLockMode.Locked;
    }
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "diedie")
        {

            Debug.Log("toca");
            muere();

        }

    }
    private void muere()
    {
        transform.position = inicio;

    }






}
