using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboUpdate : MonoBehaviour
{
    void Update()
    {
        GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo.transform.position = new Vector3(
            Random.Range(-5f, 5f),
            Random.Range(-5f, 5f),
            Random.Range(-5f, 5f)
        );

        Renderer rend = cubo.GetComponent<Renderer>();
        rend.material.color = new Color(
            Random.value,
            Random.value,
            Random.value
        );

        Debug.Log("Cubo creado con color aleatorio en Update()");
    }
}