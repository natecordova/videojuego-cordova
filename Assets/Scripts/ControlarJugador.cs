﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlarJugador : MonoBehaviour
{

    public float alturaSalto;


    public float velocidadMovimiento;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       



        if (Input.GetKeyDown (KeyCode.Space)){


            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, alturaSalto);

        }

        if (Input.GetKey(KeyCode.D))
        {


            GetComponent<Rigidbody2D>().velocity = new Vector2(velocidadMovimiento, GetComponent<Rigidbody2D>().velocity.y);

        }

        if (Input.GetKey(KeyCode.A))
        {


            GetComponent<Rigidbody2D>().velocity = new Vector2(-velocidadMovimiento, GetComponent<Rigidbody2D>().velocity.y);

        }


   




    }
}
