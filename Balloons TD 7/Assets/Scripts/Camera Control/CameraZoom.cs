using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    
    
    [Header("References")]
    public Camera main;

    [Header("Preferences")] 
    public float speed;
    public float smoothing;
    public float minZoom;
    public float maxZoom;
    
    
    private float _targetZoom;
    private float _scrollData;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _targetZoom = main.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        _scrollData = Input.GetAxis("Mouse ScrollWheel");

        _targetZoom -= speed * _scrollData;
        _targetZoom = Mathf.Clamp(_targetZoom, minZoom, maxZoom);
    }

    private void FixedUpdate()
    {
        main.orthographicSize = Mathf.Lerp(main.orthographicSize, _targetZoom, 1 / smoothing);
    }
}
