using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptVidas : MonoBehaviour
{
    private Animator animatorVidas;
    void Start()
    {
        animatorVidas = GetComponent<Animator>(); 
        animatorVidas.SetInteger("Vidas", this.GetComponentInParent<Moverse>().vida);

    }

    public void cambiarVidas (int numVidas){  
        animatorVidas.SetInteger("Vidas", numVidas);
    }
}
