using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboAwake : MonoBehaviour
{
    void Awake()
    {
        GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo.transform.position = new Vector3(-12f, 0f, 0f);
        Debug.Log("Cubo creado en Awake()");
    }
}