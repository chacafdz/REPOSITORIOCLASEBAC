using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeSpawner : MonoBehaviour
{
    public GameObject PrefabCubo;
    public List<GameObject> ListaDeCubos;
    public float FactorDeEscalamiento;
        public int numCubos = 0;

    // Start is called before the first frame update
    void Start()
    {
        ListaDeCubos = new List<GameObject>();

    }

    // Update is called once per frame
    void Update()
    {
        numCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubo);
        tempGameObject.name = "CuboNumero" + numCubos;
        Color c = new Color(Random.value,Random.value,Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;

        ListaDeCubos.Add(tempGameObject);
        List<GameObject> objetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in ListaDeCubos)
        {
            float escala = go.transform.localScale.x;
            escala *= FactorDeEscalamiento;
            go.transform.localScale = Vector3.one * escala;

            if (escala <= 0.1)
            {
                objetosParaEliminar.Add(go);

            }
                }
foreach (GameObject go in objetosParaEliminar)
        {
            ListaDeCubos.Remove(go);
            Destroy(go);

        }
    }
}
