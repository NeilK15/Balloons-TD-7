using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDrag : MonoBehaviour
{

    public Camera main;
    
    private Vector3 _origin;
    private Vector3 _difference;
    private Vector3 _resetCamera;

    private bool _drag = false;
    
    // Start is called before the first frame update
    void Start()
    {
        _resetCamera = main.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetButton("Camera Drag"))
        {
            _difference = (main.ScreenToWorldPoint(Input.mousePosition)) - main.transform.position;
            if (_drag == false)
            {
                _drag = true;
                _origin = main.ScreenToWorldPoint(Input.mousePosition);
            }
        }
        else
        {
            _drag = false;
        }

        if (_drag)
        {
            main.transform.position = _origin - _difference;
        }

        
    }
}
