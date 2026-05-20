using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboBooleano2 : MonoBehaviour
{
    public bool valor = false;

    void FixedUpdate()
    {
        valor = !valor;

        Renderer rend = GetComponent<Renderer>();
        rend.material.color = valor ? Color.white : Color.black;

        Debug.Log("GO2 valor: " + valor);
    }
}