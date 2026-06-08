using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables3 : MonoBehaviour
{
    private int contador = 0;

    void FixedUpdate()
    {
        contador++;
        Renderer rend = GetComponent<Renderer>();

        if (contador % 2 == 0)
        {
            rend.material.color = Color.green; // par
            Debug.Log(contador + " es PAR");
        }
        else
        {
            rend.material.color = Color.red; // impar
            Debug.Log(contador + " es IMPAR");
        }
    }
}