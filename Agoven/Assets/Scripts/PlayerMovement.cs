using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 1;
    public float sidewaysForce = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce, 0, 0);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce, 0, 0);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce);
        }
    }
}
