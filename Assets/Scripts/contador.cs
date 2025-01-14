using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class contador : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI contadorsetas;
    private int setas = 0;


    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        sumasetas();
    }
    public void sumasetas()
    {
        setas++;
        contadorsetas.text = "x " + setas;

    }
}
