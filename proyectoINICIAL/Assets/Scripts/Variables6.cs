using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables6 : MonoBehaviour
{
    void Start()
    {
        string nombreCompleto = "Juan Carlos Perez";

        // Substring - separar manualmente
        string nombre = nombreCompleto.Substring(0, 4);
        string apellido1 = nombreCompleto.Substring(5, 6);
        string apellido2 = nombreCompleto.Substring(12);

        Debug.Log("Nombre: " + nombre);
        Debug.Log("Apellido1: " + apellido1);
        Debug.Log("Apellido2: " + apellido2);

        // Split - separar por espacios en lista
        string[] partes = nombreCompleto.Split(' ');
        foreach (string parte in partes)
        {
            Debug.Log("Split: " + parte);
        }
    }
}