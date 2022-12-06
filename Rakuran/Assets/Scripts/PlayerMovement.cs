using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float sidewayForce = 250f;
    public bool Movement = true;

    void FixedUpdate()
    {
        if (Movement == true)
        {

            if (Input.GetKey("l"))
            {
                rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (Input.GetKey("j"))
            {
                rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

        }



    }

}


