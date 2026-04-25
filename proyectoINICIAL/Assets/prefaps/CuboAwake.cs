using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboAwake : MonoBehaviour
{
    void Awake()
    {
        GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo.transform.position = new Vector3(0f, 0f, 0f);

        Renderer rend = cubo.GetComponent<Renderer>();
        rend.material.color = new Color(
            Random.value,
            Random.value,
            Random.value
        );

        Debug.Log("Cubo creado con color aleatorio en Awake()");
    }
}