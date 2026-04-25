using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboOnEnableDisable : MonoBehaviour
{
    void OnEnable()
    {
        GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo.transform.position = new Vector3(10f, 0f, 0f);
        Debug.Log("Cubo creado en OnEnable()");
    }

    void OnDisable()
    {
        GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo.transform.position = new Vector3(-2f, 0f, 0f);
        Debug.Log("Cubo creado en OnDisable()");
    }
}