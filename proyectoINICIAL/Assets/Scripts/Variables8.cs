using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables8 : MonoBehaviour
{
    void Start()
    {
        string oracion = "Hola Mundo";
        string resultado = "";

        for (int i = 0; i < oracion.Length; i++)
        {
            if (i % 2 == 0)
            {
                resultado += oracion[i];
            }
        }

        Debug.Log("Caracteres en índice par: " + resultado);
        // Output: H l  u d
    }
}