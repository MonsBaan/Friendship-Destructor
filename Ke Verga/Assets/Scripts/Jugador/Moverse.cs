using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moverse : MonoBehaviour
{
    [Header("Vida de Personaje")]
    public int vida = 3;
    [Header("Puntos de Accion")]
    public int puntosAccion;
    [Header("Rango Disparo")]
    public int rangoDisparo = 2;
    [Header("Velocidad movimiento")]
    public float velocidad;
    private GameObject mapa;
    private float tamañoCasilla;
    private Transform moñecoTransform;
    public bool isMoving;
    private bool isMenu;
    public Vector3 moveTo;
    void Start()
    {
        moñecoTransform = this.transform;
        isMenu = false;
        mapa = GameObject.Find("Mapa");
        tamañoCasilla = GameObject.Find("Mapa").GetComponent<EventosMapa>().tamañoCasilla;
        moveTo = moñecoTransform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if(vida <= 0){
            moñecoTransform.Find("Vidas").gameObject.SetActive(false);
        }else
        {
            moñecoTransform.Find("Vidas").gameObject.SetActive(true);
            moñecoTransform.Find("Vidas").GetComponent<ScriptVidas>().cambiarVidas(vida);
        }

        teclasMovimiento();
        if (isMoving)
        {
            moverPersonaje();
        }
    }

    public void moverPersonaje(){   
        
        if (Vector3.Distance(moñecoTransform.position, moveTo) < 0.1){
            isMoving = false;
            moñecoTransform.position = moveTo;
        }            
        else
        {
            //Movimiento Izquierda y Derecha
            if(moñecoTransform.position.x > moveTo.x)
                moñecoTransform.Translate(Vector3.left * velocidad);
            else if(moñecoTransform.position.x < moveTo.x)
                moñecoTransform.Translate(Vector3.right * velocidad);
            
            //Movimiento Arriba y Abajo
            if(moñecoTransform.position.y < moveTo.y)
                moñecoTransform.Translate(Vector3.up * velocidad);
            else if(moñecoTransform.position.y > moveTo.y)
                moñecoTransform.Translate(Vector3.down * velocidad);
        }


    }

    private void teclasMovimiento(){
        if (Input.GetKeyDown("left"))
        {
            isMoving = true;
            moveTo.x -= tamañoCasilla;
        }
        else if (Input.GetKeyDown("right"))
        {
            isMoving = true;
            moveTo.x += tamañoCasilla;        
        }
        else if (Input.GetKeyDown("up"))
        {
            isMoving = true;
            moveTo.y += tamañoCasilla;        
        }
        else if (Input.GetKeyDown("down"))
        {
            isMoving = true;
            moveTo.y -= tamañoCasilla;        
        }
    }
    void OnMouseDown()
    {
    GameObject menu = moñecoTransform.Find("MenuInteracciones").gameObject;

    if (isMenu)
        isMenu = false;
    else
        isMenu = true;

    menu.SetActive(isMenu);

    }

    
 }
