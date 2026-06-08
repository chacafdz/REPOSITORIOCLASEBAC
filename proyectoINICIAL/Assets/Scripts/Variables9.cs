using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables9 : MonoBehaviour
{
    void Start()
    {
        string oracion = "Hola Mundo está aquí";

        // Con Substring
        string resultado = oracion.Substring(5);
        Debug.Log("Sin primeros 5 caracteres: " + resultado);
        // Output: Mundo está aquí
    }
}