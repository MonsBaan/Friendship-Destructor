using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moverse : MonoBehaviour
{
    private Color colorOriginalMovimiento;

    [Header("Vida de Personaje")]
    public int vida = 3;
    [Header("Rango de Movimiento del Personaje")]
    public int numeroRangoCasillas = 2;
    [Header("Rango de Movimiento del Personaje")]
    public int numeroRangoDisparos = 3;
    [Header("Mapa")]
    public GameObject mapa;


    private Transform moñecoTransform;

    void Start()
    {
        moñecoTransform = this.transform;
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



        if (Input.GetKeyDown("left"))
        {
            moñecoTransform.position = new Vector3(gameObject.transform.position.x - 26, gameObject.transform.position.y, gameObject.transform.position.z);
            //gameObject.GetComponent<Animator>().SetBool("MoveR", true);
        }
        else if (Input.GetKeyDown("right"))
        {
            moñecoTransform.position = new Vector3(gameObject.transform.position.x + 26, gameObject.transform.position.y, gameObject.transform.position.z);
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

    }
}
