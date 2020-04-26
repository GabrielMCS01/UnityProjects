using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevador : MonoBehaviour
{

    private int AlternadorElevador = 0;
    private int Contador = 0;

    // Update is called once per frame
    private void Update()
    {

        if (transform.position.y < 50.5 && AlternadorElevador == 0)
        {
            transform.position += transform.up * (Time.deltaTime * 3);
        }

        if (AlternadorElevador == 0 && transform.position.y >= 50.5)
        {
            Contador ++;

            if ( Contador > 350 )
            {
                AlternadorElevador = 1;
                Contador = 0;
            } 
        }

        if (transform.position.y > 14.65 && AlternadorElevador == 1)
        {
            transform.position -= transform.up  * (Time.deltaTime * 3);
        }

        if (AlternadorElevador == 1 && transform.position.y <= 14.65)
        {
            Contador ++;

            if (Contador > 350)
            {
                AlternadorElevador = 0;
                Contador = 0;
            }
        }
    }
}
