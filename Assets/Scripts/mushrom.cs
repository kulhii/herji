using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class mushrom : MonoBehaviour
{
    [SerializeField] private GameObject destroy;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Destroy(gameObject);    }

   
}
