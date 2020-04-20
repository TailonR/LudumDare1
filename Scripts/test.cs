using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    float startTime;
    Vector3 width;
    float newStartTime;
    bool big;
    void Start()
    {
        startTime = Time.time;
        width = rb.transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        float endTime = Time.time - startTime;
        if(endTime > 10 && !big)
        {
            width.x = 30;
            rb.transform.localScale = width;
            endTime = 0;
            startTime = Time.time;
            big = true;
        }
        if(endTime > 3 && big)
        {
            width.x = 1;
            rb.transform.localScale = width;
            endTime = 0;
            startTime = Time.time;
            big = false;
        }
        
    }
}
