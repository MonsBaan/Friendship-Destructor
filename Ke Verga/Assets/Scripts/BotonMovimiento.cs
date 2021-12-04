using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonMovimiento : MonoBehaviour
{
    private Moverse mov;
    public GameObject jugador;

    // Start is called before the first frame update
    void Start()
    {
        mov = FindObjectOfType<Moverse>();
        mov.rango.transform.position = new Vector3(jugador.transform.position.x, jugador.transform.position.y, jugador.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        // Para que al hacer click en el boton de los pasos se oculte el menu
        mov.OnMouseDown();

        // Colocar las casillas de movimiento
        mov.MostrarOcultarCasillas();
        mov.arriba.transform.position = new Vector3(jugador.transform.position.x, jugador.transform.position.y + 13, jugador.transform.position.z);
        mov.abajo.transform.position = new Vector3(jugador.transform.position.x, jugador.transform.position.y - 39, jugador.transform.position.z);
        mov.der.transform.position = new Vector3(jugador.transform.position.x + 26, jugador.transform.position.y - 13, jugador.transform.position.z);
        mov.izq.transform.position = new Vector3(jugador.transform.position.x - 26, jugador.transform.position.y - 13, jugador.transform.position.z);
        mov.arribaDer.transform.position = new Vector3(jugador.transform.position.x + 26, jugador.transform.position.y + 13, jugador.transform.position.z);
        mov.arribaIzq.transform.position = new Vector3(jugador.transform.position.x - 26, jugador.transform.position.y + 13, jugador.transform.position.z);
        mov.abajoDer.transform.position = new Vector3(jugador.transform.position.x + 26, jugador.transform.position.y - 39, jugador.transform.position.z);
        mov.abajoIzq.transform.position = new Vector3(jugador.transform.position.x - 26, jugador.transform.position.y - 39, jugador.transform.position.z);
    }
}
