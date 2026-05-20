using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboOR : MonoBehaviour
{
    public CuboBooleano1 go1;
    public CuboBooleano2 go2;

    public bool valor = false;
    void FixedUpdate()
    {
        valor = go1.valor || go2.valor;

        Renderer rend = GetComponent<Renderer>();
        rend.material.color = valor ? Color.white : Color.black;

        Debug.Log("GO4 OR: " + valor);
    }
}