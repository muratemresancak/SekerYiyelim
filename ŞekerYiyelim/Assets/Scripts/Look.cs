using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    [SerializeField]
    float _sensitivity = 5.0f;

    float _mouseX = 0.0f;
    float _mouseY = 0.0f;
    void Start()
    {
        
    }

   
    void Update()
    {
        _mouseX = Input.GetAxis("Mouse X");
        Vector3 rot = transform.localEulerAngles;
        rot.y += _mouseX * _sensitivity;
        transform.localEulerAngles = rot;


        _mouseY = -Input.GetAxis("Mouse Y");
        Vector3 yukari = transform.localEulerAngles;
        yukari.x += _mouseY * _sensitivity;
        transform.localEulerAngles = yukari;
    }
}
