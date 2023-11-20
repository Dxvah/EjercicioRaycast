using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    Rigidbody rb;
    bool isGrounded;
    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();

        }
    }
    void Jump()
    {
        Vector3 origen = transform.position;
        Vector3 direccion = transform.forward;
        RaycastHit golpe;
        if (Physics.Raycast(origen, direccion, out golpe))
        {



        }



    }
}
