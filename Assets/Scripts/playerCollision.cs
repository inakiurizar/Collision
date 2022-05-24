using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    bool salto = false;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "DeathWall")
        {
            transform.position = new Vector3(3.47f, 0.5f, 3.45f);
            transform.eulerAngles = new Vector3(0,0,0);
        }
        if (salto == true)
        {
            salto = false;
        }
    }

    void OnCollisionExit()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            salto = true;
        }
        if (salto == false)
        {
            transform.position = new Vector3(3.47f, 0.5f, 3.45f);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
