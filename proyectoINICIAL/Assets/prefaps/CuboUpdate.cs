using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboUpdate : MonoBehaviour
{
    public GameObject cuboPrefab;

    void Update()
    {
        GameObject cubo = Instantiate(
            cuboPrefab,
            new Vector3(
                Random.Range(-5f, 5f),
                Random.Range(-5f, 5f),
                Random.Range(-5f, 5f)
            ),
            Quaternion.identity
        );

        Renderer rend = cubo.GetComponent<Renderer>();
        rend.material.color = new Color(
            Random.value,
            Random.value,
            Random.value
        );

        Debug.Log("Cubo instanciado con color aleatorio en Update()");
    }
}