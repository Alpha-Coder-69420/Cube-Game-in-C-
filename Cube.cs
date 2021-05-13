using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour


{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {  
        rb = GetComponent<Rigidbody>();
        gameObject.GetComponent<Renderer>().material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 400);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(Vector3.left * 400);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(Vector3.right * 400);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * 400);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(Vector3.back * 400);
        }



            

    }
}
