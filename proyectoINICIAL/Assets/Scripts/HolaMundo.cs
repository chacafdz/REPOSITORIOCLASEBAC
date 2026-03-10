using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    int x;

    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        print("Algo paso");
        Debug.LogWarning("Algo salio medianamente mal");
        Debug.LogError("Algo salio muy mal");
    } // <-- The Start method ends here

    // Update is called once per frame
    void Update() // <-- Update should be OUTSIDE of Start
    {
        //x += 1;
        //Debug.Log(x);
        Debug.Log("hola desde update");
    }
    private void FixedUpdate()
    {
        Debug.Log("hola desde fixed Update cada 50 frames");
    }
    private void LateUpdate()
    {
        Debug.Log(" hola desde Late Uodate ");
    }
    private void OnEnable()
    {
        Debug.Log("EL objeto ha sido hablitado ");
    }
    private void OnDisable()
    {
        Debug.Log("el objeto ha sido inhabilitado");
    }
}