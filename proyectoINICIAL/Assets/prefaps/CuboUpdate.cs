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
        Debug.Log("Cubo creado en Update()");
    }
}