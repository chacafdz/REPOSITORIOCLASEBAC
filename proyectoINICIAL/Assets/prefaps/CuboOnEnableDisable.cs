using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboOnEnableDisable : MonoBehaviour
{
    private GameObject cuboEnable;
    private GameObject cuboDisable;

    void OnEnable()
    {
        cuboEnable = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cuboEnable.transform.position = new Vector3(2f, 0f, 0f);

        Renderer rend = cuboEnable.GetComponent<Renderer>();
        rend.material.color = new Color(
            Random.value,
            Random.value,
            Random.value
        );

        Debug.Log("Cubo creado con color aleatorio en OnEnable()");
    }

    void OnDisable()
    {
        cuboDisable = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cuboDisable.transform.position = new Vector3(-2f, 0f, 0f);

        Renderer rend = cuboDisable.GetComponent<Renderer>();
        rend.material.color = new Color(
            Random.value,
            Random.value,
            Random.value
        );

        Debug.Log("Cubo creado con color aleatorio en OnDisable()");
    }

    void FixedUpdate()
    {
        if (cuboEnable != null)
        {
            Renderer rend = cuboEnable.GetComponent<Renderer>();
            rend.material.color = new Color(
                Random.value,
                Random.value,
                Random.value
            );
        }

        if (cuboDisable != null)
        {
            Renderer rend = cuboDisable.GetComponent<Renderer>();
            rend.material.color = new Color(
                Random.value,
                Random.value,
                Random.value
            );
        }

        Debug.Log("Color cambiado en FixedUpdate()");
    }
}