using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomControl : MonoBehaviour
{
    public float maxZoom;
    public float minZoom;
    private float zoomSize;
    // Start is called before the first frame update
    void Start()
    {
        zoomSize = maxZoom;
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetAxis("Mouse ScrollWheel") > 0 && zoomSize > minZoom)
            {
                zoomSize -= 15;
            }
            if(Input.GetAxis("Mouse ScrollWheel") < 0 && zoomSize < maxZoom){
                zoomSize += 15;

            }
            GetComponent<Camera>().orthographicSize  = zoomSize-1;
        


    }
}
