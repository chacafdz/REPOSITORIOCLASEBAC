using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables4 : MonoBehaviour
{
    public string palabra = "fuego";

    void Start()
    {
        Renderer rend = GetComponent<Renderer>();

        switch (palabra)
        {
            case "fuego":
                rend.material.color = Color.red;
                break;
            case "agua":
                rend.material.color = Color.blue;
                break;
            case "tierra":
                rend.material.color = new Color(0.5f, 0.25f, 0f);
                break;
            case "aire":
                rend.material.color = Color.white;
                break;
            default:
                rend.material.color = Color.gray;
                break;
        }

        Debug.Log("Palabra: " + palabra);
    }
}