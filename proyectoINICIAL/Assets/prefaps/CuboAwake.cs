using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboAwake : MonoBehaviour
{
    public GameObject cuboPrefab;

    void Awake()
    {
        GameObject cubo = Instantiate(cuboPrefab, new Vector3(0f, 0f, 0f), Quaternion.identity);

        Renderer rend = cubo.GetComponent<Renderer>();
        rend.material.color = new Color(
            Random.value,
            Random.value,
            Random.value
        );

        Debug.Log("Cubo instanciado con color aleatorio en Awake()");
    }
}