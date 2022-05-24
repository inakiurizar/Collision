using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    public float jump;
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0,0, movementSpeed);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -movementSpeed);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationSpeed, 0);
        } 
        else if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, jump, 0);
        }
        
    }
}
