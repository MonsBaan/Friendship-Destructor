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
    public int rangoDisparo;
    [Header("Rango Movimiento")]
    public int rangoMovimiento ;
    [Header("Velocidad movimiento")]
    public float velocidad;
    private GameObject mapa;
    private float tamañoCasilla;
    private Transform moñecoTransform;
    private Animator moñecoAnimator;
    public bool isMoving;
    private int dirMovimiento;
    private bool isMenu;
    public Vector3 moveTo;
    void Start()
    {
        moñecoTransform = this.transform;
        moñecoAnimator = moñecoTransform.GetComponent<Animator>();
        isMenu = false;
        dirMovimiento = 0;
        mapa = GameObject.Find("Mapa");
        tamañoCasilla = GameObject.Find("Mapa").GetComponent<EventosMapa>().tamañoCasilla;
        moveTo = moñecoTransform.position;

    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("RangoMovimiento").transform.localScale = new Vector3(60 * rangoMovimiento, 60 * rangoMovimiento, 1);


        if(vida <= 0){
            moñecoTransform.Find("Vidas").gameObject.SetActive(false);
        }else
        {
            moñecoTransform.Find("Vidas").gameObject.SetActive(true);
            moñecoTransform.Find("Vidas").GetComponent<ScriptVidas>().cambiarVidas(vida);
        }

        if (isMoving)
            moverPersonaje();

        moñecoAnimator.SetInteger("Direccion", dirMovimiento);

    }

    public void moverPersonaje(){   
        
        if (Vector3.Distance(moñecoTransform.position, moveTo) < 1){
            isMoving = false;
            moñecoTransform.position = moveTo;
            dirMovimiento = 0;

        }            
        else
        {
            //Movimiento Izquierda y Derecha
            if(moñecoTransform.position.x > moveTo.x){
                moñecoTransform.Translate(Vector3.left * velocidad);
                moñecoTransform.localScale = new Vector3(-1, 1, 1);
                dirMovimiento = 3;
            }
            else if(moñecoTransform.position.x < moveTo.x){
                moñecoTransform.Translate(Vector3.right * velocidad);
                moñecoTransform.localScale = new Vector3(1, 1, 1);
                dirMovimiento = 3;
            }
            
            //Movimiento Arriba y Abajo
            if(moñecoTransform.position.y < moveTo.y){
                moñecoTransform.Translate(Vector3.up * velocidad);
                dirMovimiento = 2;
            }
            else if(moñecoTransform.position.y > moveTo.y){
                moñecoTransform.Translate(Vector3.down * velocidad);
                dirMovimiento = 1;

            }
        }
    }
    void OnMouseDown()
    {
    if (isMenu)
        isMenu = false;
    else
        isMenu = true;
    
    setMenu(isMenu);
    dirMovimiento = 0;

    }

    public void setMenu(bool estado){
        GameObject menu = moñecoTransform.Find("MenuInteracciones").gameObject;
        isMenu = estado;
        menu.SetActive(estado);

    }

    public void setDir(int direccion){
        dirMovimiento = direccion;
    }

    public void moverse(Vector3 goTo){
        moveTo = goTo;
    }

    
 }
