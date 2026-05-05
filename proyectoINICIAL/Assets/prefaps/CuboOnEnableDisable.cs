using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboOnEnableDisable : MonoBehaviour
{
    public GameObject cuboPrefab;

    private GameObject cuboEnable;
    private GameObject cuboDisable;

    void OnEnable()
    {
        cuboEnable = Instantiate(cuboPrefab, new Vector3(2f, 0f, 0f), Quaternion.identity);

        Renderer rend = cuboEnable.GetComponent<Renderer>();
        rend.material.color = new Color(
            Random.value,
            Random.value,
            Random.value
        );

        Debug.Log("Cubo instanciado con color aleatorio en OnEnable()");
    }

    void OnDisable()
    {
        cuboDisable = Instantiate(cuboPrefab, new Vector3(-2f, 0f, 0f), Quaternion.identity);

        Renderer rend = cuboDisable.GetComponent<Renderer>();
        rend.material.color = new Color(
            Random.value,
            Random.value,
            Random.value
        );

        Debug.Log("Cubo instanciado con color aleatorio en OnDisable()");
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