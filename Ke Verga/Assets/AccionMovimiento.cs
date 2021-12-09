using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccionMovimiento : MonoBehaviour
{
    public GameObject moñecoParent;
    public Transform[] array;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        moñecoParent.GetComponent<Moverse>().setDir(1);
        GetComponent<CircleCollider2D>().enabled = true;
        GetComponent<CircleCollider2D>().radius = moñecoParent.GetComponent<Moverse>().rangoMovimiento*30.6f;
        moñecoParent.GetComponent<Moverse>().setMenu(false);
        
    }
}
