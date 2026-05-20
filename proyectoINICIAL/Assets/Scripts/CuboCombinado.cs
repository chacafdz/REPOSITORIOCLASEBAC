using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboCombinado : MonoBehaviour
{
    public CuboAND go3;
    public CuboOR go4;

    private bool valor = false;

    void FixedUpdate()
    {
        valor = go3.valor && go4.valor;

        Renderer rend = GetComponent<Renderer>();
        rend.material.color = valor ? Color.white : Color.black;

        Debug.Log("GO5 Combinado (AND): " + valor);
    }
}