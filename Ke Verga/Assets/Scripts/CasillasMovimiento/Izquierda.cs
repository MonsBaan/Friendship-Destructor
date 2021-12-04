using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Izquierda : MonoBehaviour
{
    private Color colorOriginal;

    public GameObject jugador;

    private Moverse mov;

    // Start is called before the first frame update
    void Start()
    {
        colorOriginal = this.gameObject.GetComponent<SpriteRenderer>().color;

        mov = FindObjectOfType<Moverse>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        mov.MostrarOcultarCasillas();
        if(jugador.transform.position.x > -247)
        {
            jugador.transform.position = new Vector3(jugador.transform.position.x - 26, jugador.transform.position.y, jugador.transform.position.z);
        }
        
    }

    private void OnMouseEnter()
    {
        SpriteRenderer sprite = gameObject.GetComponent<SpriteRenderer>();
        sprite.color = Color.cyan;
    }

    private void OnMouseExit()
    {
        SpriteRenderer sprite = gameObject.GetComponent<SpriteRenderer>();
        sprite.color = colorOriginal;
    }
}
