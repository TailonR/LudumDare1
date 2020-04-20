using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axeMvmnt : MonoBehaviour
{
    public HingeJoint hinging;
    public bool positiveRotation = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        var motor = hinging.motor;
        motor.targetVelocity = -hinging.motor.targetVelocity;
        motor.force = 400;
        if (Mathf.Abs(transform.rotation.eulerAngles.x - 34f) < 5f && !positiveRotation)
        {
            hinging.motor = motor;
            positiveRotation = true;
            return;
        }
        if (Mathf.Abs(transform.rotation.eulerAngles.x - 326f) < 5f && positiveRotation)
        {
            hinging.motor = motor;
            positiveRotation = false;
            return;
        }

    }
}
