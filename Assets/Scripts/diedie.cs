using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class diedie : MonoBehaviour
{
    private Vector3 inicio;


    // Start is called before the first frame update
    void Start()
    {
        inicio = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "diedie")
        {

            Debug.Log("toca");
            muere();

        }

    }
    private void muere(){
        transform.position = inicio;

    }

}
