using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Variables7 : MonoBehaviour
{
    void Start()
    {
        string num1 = "5000";
        string num2 = "3000";

        if (int.TryParse(num1, out int valor1) && int.TryParse(num2, out int valor2))
        {
            int resultado = valor1 + valor2;
            Debug.Log("Resultado: " + resultado);
        }
        else
        {
            Debug.LogError("No se pudo convertir alguno de los strings.");
        }
    }
}