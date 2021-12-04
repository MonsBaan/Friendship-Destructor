using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonDisparo : MonoBehaviour
{
    private Moverse mov;
    public GameObject jugador;

    // Start is called before the first frame update
    void Start()
    {
        mov = FindObjectOfType<Moverse>();
        mov.rango.transform.position = new Vector3(jugador.transform.position.x, jugador.transform.position.y, jugador.transform.position.z);
        mov.rango.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        mov.OnMouseDown();

        // Ocultar o mostrar el rango
        mov.rango.enabled = !mov.rango.enabled;
        mov.rango.color = Color.red;
        if (mov.rango.enabled)
        {
            // Poner la escala del rango en funcion del rango de movimiento (de momento siempre es uno)
            mov.rango.transform.localScale = new Vector3(mov.tamanoCasilla * (mov.numeroRangoDisparos + 2), mov.tamanoCasilla * (mov.numeroRangoDisparos + 2), jugador.transform.position.z);

            // Colocar el rango en la posicion del jugador un poquito mas abajo
            mov.rango.transform.position = new Vector3(jugador.transform.position.x, jugador.transform.position.y - 13, jugador.transform.position.z);
        }
        else
        {
            //
        }
    }
}
