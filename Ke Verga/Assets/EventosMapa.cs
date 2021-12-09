using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventosMapa : MonoBehaviour
{
    [Header("Numero de Casillas Horizontales")]
    public int numHorizontal;    
    [Header("Numero de Casillas Verticales")]
    public int numVertical;
    [Header("Tamaño de cada casilla")]
    public float tamañoCasilla;
    [Header("Casilla Original")]
    public GameObject casillaOriginal;
    public List<GameObject> arrayCasillas;

    // Start is called before the first frame update
    void Start()
    {
        arrayCasillas = new List<GameObject>();

        Vector3 posicionOriginal = casillaOriginal.transform.position;
        Vector3 posicion = posicionOriginal;

        for (int i = 1; i <= numHorizontal*numVertical; i++)
        {

            var casillaPrefab = Instantiate(casillaOriginal, posicion, Quaternion.identity);

            casillaPrefab.name = "Casilla"+i;
            arrayCasillas.Add(casillaPrefab);
            posicion.x += tamañoCasilla;
            if (i % numHorizontal== 0)
            {
                posicion.x = posicionOriginal.x;
                posicion.y -= tamañoCasilla;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
