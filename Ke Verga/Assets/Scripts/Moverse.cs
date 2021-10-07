using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moverse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x -26, gameObject.transform.position.y, gameObject.transform.position.z);
            gameObject.GetComponent<Animator>().SetBool("MoveR", true);
        }
       if (Input.GetKeyDown("right"))
        {
            gameObject.transform.position = (gameObject.transform.position.x +26, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if (Input.GetKeyDown("up"))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y +26, gameObject.transform.position.z);
        }
       if (Input.GetKeyDown("down"))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y -26, gameObject.transform.position.z);
        }
    }
}
