using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed = 1f;

    [HideInInspector]public float mouseX;

    [HideInInspector]public float mouseY;
    public float a;
    public float b;

  
    private void Update()
    {
        if (Input.GetMouseButton(0)) 
        {
            mouseX = Input.GetAxis("Mouse X") * rotateSpeed;
            mouseY = Input.GetAxis("Mouse Y") * rotateSpeed;
            mouseX = mouseX*a;
            mouseY = mouseY * b;
            transform.Rotate(Vector3.down,mouseX);
            transform.Rotate(Vector3.forward,mouseY);
        }
       
    }
}
