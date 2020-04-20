using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxCollision : MonoBehaviour
{
    public axeMvmnt axeMvmnt;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("You hit the something" + collisionInfo.collider.tag);
        if(collisionInfo.collider.tag == "axe")
        {
            Debug.Log("You hit the axe");
            axeMvmnt.enabled = false;
        }
    }
}
