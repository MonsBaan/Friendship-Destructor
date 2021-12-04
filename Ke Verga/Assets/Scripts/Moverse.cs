using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moverse : MonoBehaviour
{
    private Color colorOriginalMovimiento;

    public float vida = 3f;

    public SpriteRenderer imagenVida;

    public SpriteRenderer vida1;
    public SpriteRenderer vida2;
    public SpriteRenderer vida3;
    public SpriteRenderer vida4;
    public SpriteRenderer vida5;
    public SpriteRenderer vida6;
    public SpriteRenderer vida7;
    public SpriteRenderer vida8;
    public SpriteRenderer vida9;


    public SpriteRenderer arriba;
    public SpriteRenderer abajo;
    public SpriteRenderer izq;
    public SpriteRenderer der;
    public SpriteRenderer arribaIzq;
    public SpriteRenderer arribaDer;
    public SpriteRenderer abajoIzq;
    public SpriteRenderer abajoDer;

    public SpriteRenderer pasos;
    public SpriteRenderer disparo;
    public SpriteRenderer aumentarRango;
    public SpriteRenderer aumentarVida;

    public SpriteRenderer rango;
    public float numeroRangoCasillas = 2;
    public float numeroRangoDisparos = 3;

    public float tamanoCasilla = 26f;

    // Start is called before the first frame update
    void Start()
    {
        arriba.enabled = false;
        der.enabled = false;
        izq.enabled = false;
        arribaDer.enabled = false;
        arribaIzq.enabled = false;
        abajo.enabled = false;
        abajoDer.enabled = false;
        abajoIzq.enabled = false;

        pasos.enabled = false;
        disparo.enabled = false;
        aumentarRango.enabled = false;
        aumentarVida.enabled = false;

        vida1.enabled = false;
        vida2.enabled = false;
        vida3.enabled = false;
        vida4.enabled = false;
        vida5.enabled = false;
        vida6.enabled = false;
        vida7.enabled = false;
        vida8.enabled = false;
        vida9.enabled = false;

        imagenVida.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + 8, transform.position.z);
        colorOriginalMovimiento = arriba.color;


    }

    // Update is called once per frame
    void Update()
    {
        imagenVida.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + 8, transform.position.z);

        switch (vida)
        {
            case 1:
                imagenVida.sprite = vida1.sprite;
                break;
            case 2:
                imagenVida.sprite = vida2.sprite;
                break;
            case 3:
                imagenVida.sprite = vida3.sprite;
                break;
            case 4:
                imagenVida.sprite = vida4.sprite;
                break;
            case 5:
                imagenVida.sprite = vida5.sprite;
                break;
            case 6:
                imagenVida.sprite = vida6.sprite;
                break;
            case 7:
                imagenVida.sprite = vida7.sprite;
                break;
            case 8:
                imagenVida.sprite = vida8.sprite;
                break;
            case 9:
                imagenVida.sprite = vida9.sprite;
                break;
            default:
                imagenVida.sprite = vida3.sprite;
                break;
        }

        if (Input.GetKeyDown("left"))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - 26, gameObject.transform.position.y, gameObject.transform.position.z);
            //gameObject.GetComponent<Animator>().SetBool("MoveR", true);
        }
        else if (Input.GetKeyDown("right"))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 26, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        else if (Input.GetKeyDown("up"))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 26, gameObject.transform.position.z);
        }
        else if (Input.GetKeyDown("down"))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 26, gameObject.transform.position.z);
        }
    }

    // Abre el menu de acciones (de momento solo moverse y subir vida)
    public void OnMouseDown()
    {
        // Boton para moverse
        pasos.enabled = !pasos.enabled;
        pasos.gameObject.SetActive(pasos.enabled);
        pasos.transform.position = new Vector3(transform.position.x, transform.position.y - 17, transform.position.z +10);

        // Boton para disparar
        disparo.enabled = !disparo.enabled;
        disparo.gameObject.SetActive(pasos.enabled);
        disparo.transform.position = new Vector3(transform.position.x, transform.position.y + 27, transform.position.z);

        // Boton para aumentar el rango
        aumentarRango.enabled = !aumentarRango.enabled;
        aumentarRango.gameObject.SetActive(pasos.enabled);
        aumentarRango.transform.position = new Vector3(transform.position.x + 22, transform.position.y + 5, transform.position.z);

        // Boton para aumentar la vida
        aumentarVida.enabled = !aumentarVida.enabled;
        aumentarVida.gameObject.SetActive(pasos.enabled);
        aumentarVida.transform.position = new Vector3(transform.position.x - 22, transform.position.y + 5, transform.position.z);

        if (arriba.enabled)
        {
            MostrarOcultarCasillas();
        }

        // Si el rango esta visible, al hacer click en el jugador se oculta
        //if(rango.enabled)
        //{
        //    rango.enabled = false;
        //}
    }

    public void MostrarOcultarCasillas()
    {
        arriba.enabled = !arriba.enabled;
        arriba.gameObject.SetActive(arriba.enabled);
        arriba.color = colorOriginalMovimiento;

        abajo.enabled = !abajo.enabled;
        abajo.gameObject.SetActive(abajo.enabled);
        abajo.color = colorOriginalMovimiento;

        der.enabled = !der.enabled;
        der.gameObject.SetActive(der.enabled);
        der.color = colorOriginalMovimiento;

        izq.enabled = !izq.enabled;
        izq.gameObject.SetActive(izq.enabled);
        izq.color = colorOriginalMovimiento;

        arribaDer.enabled = !arribaDer.enabled;
        arribaDer.gameObject.SetActive(arribaDer.enabled);
        arribaDer.color = colorOriginalMovimiento;

        arribaIzq.enabled = !arribaIzq.enabled;
        arribaIzq.gameObject.SetActive(arribaIzq.enabled);
        arribaIzq.color = colorOriginalMovimiento;

        abajoDer.enabled = !abajoDer.enabled;
        abajoDer.gameObject.SetActive(abajoDer.enabled);
        abajoDer.color = colorOriginalMovimiento;

        abajoIzq.enabled = !abajoIzq.enabled;
        abajoIzq.gameObject.SetActive(abajoIzq.enabled);
        abajoIzq.color = colorOriginalMovimiento;
    }
}
