using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubirVida : MonoBehaviour
{
    private Moverse mov;

    // Start is called before the first frame update
    void Start()
    {
        mov = FindObjectOfType<Moverse>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(mov.vida < 9)
        {
            mov.vida++;
        }
        mov.OnMouseDown();
    }
}
