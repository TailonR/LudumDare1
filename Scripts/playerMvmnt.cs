using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMvmnt : MonoBehaviour
{
    public Rigidbody rb;

    private float forwardForce = 12f;
    private float sidewaysForce = 12f;
    bool slowDown;
 
    void Update()
    {

        if (rb.velocity.z < -10 || slowDown == true)
        {
            rb.AddForce(0, 0, 10 * Time.deltaTime * forwardForce, ForceMode.Force);
            slowDown = true;
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(Time.deltaTime * sidewaysForce, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(Time.deltaTime * -sidewaysForce, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, Time.deltaTime * forwardForce, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, Time.deltaTime * -forwardForce, ForceMode.VelocityChange);
        }

        if (rb.position.y < 0f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
