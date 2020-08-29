using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _OceanMovment : MonoBehaviour
{

    public float timeCounter = 0;

    public float speed;
    public float width;
    public float height;

    private float _PosRetiradaEmY;
    private float _PosRetiradaEmX;

    private void Start()
    {
        _PosRetiradaEmY = transform.position.y;
        _PosRetiradaEmX = transform.position.x;
    }


    void Update()
    {
        timeCounter += Time.deltaTime * speed;

        if (timeCounter > Mathf.PI*2)
            timeCounter = 0;

         float x = Mathf.Cos(timeCounter) * width;
         float y = Mathf.Sin(timeCounter) * height;

        transform.position = new Vector3(_PosRetiradaEmX + x, _PosRetiradaEmY + y, 0);

    }
}
