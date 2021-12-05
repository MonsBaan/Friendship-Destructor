using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomControl : MonoBehaviour
{
    public float zoomSize;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                zoomSize -= 15;
            }
            if(Input.GetAxis("Mouse ScrollWheel") < 0 && zoomSize != 325){
                zoomSize += 15;

            }
            GetComponent<Camera>().orthographicSize  = zoomSize-1;
        


    }
}
