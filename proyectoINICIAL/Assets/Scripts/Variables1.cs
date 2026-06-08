using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables5 : MonoBehaviour
{
    public float numero = 3.14159265f;

    void Start()
    {
        string resultado = numero.ToString("F4");
        Debug.Log("Float con 4 decimales: " + resultado);
    }
}