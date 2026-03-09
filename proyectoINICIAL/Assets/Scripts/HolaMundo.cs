using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("algo paso");
        Debug.LogWarning("algo salio mal");
        Debug.LogError("algo salio muy mal");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("hola, algo paso");

    }
}
