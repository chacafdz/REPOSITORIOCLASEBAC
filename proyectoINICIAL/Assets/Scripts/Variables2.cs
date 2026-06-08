using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Variables2 : MonoBehaviour
{
    public float a = 7.9f;
    public float b = 3.2f;

    void Start()
    {
        float resultado = a * b;
        int resultadoInt = (int)resultado; // casteo explícito
        Debug.Log("Float: " + resultado + " | Casteado a Int: " + resultadoInt);
    }
}