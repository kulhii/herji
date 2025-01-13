using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class vidas : MonoBehaviour




{
    [SerializeField] private TextMeshProUGUI lifeText;

    private int lifes = 50;

    

    void Update()
    {
        
    }


    public void Die()
    {

        lifes--;
        lifeText.text = "x " + lifes;

    }

}
