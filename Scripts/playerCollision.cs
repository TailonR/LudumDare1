using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMvmnt playerMvmnt;
    private Rigidbody player;
    
    private float forwardForce = 25f;
    private float sidewaysForce = 12f;
    // Update is called once per frame
    private void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("You hit the " + collisionInfo.collider.tag);
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        float moveX = inputX * sidewaysForce * Time.deltaTime;
        float moveZ = inputY * forwardForce * Time.deltaTime;
        if(collisionInfo.collider.tag == "walls")
        {
            Debug.Log("The player veloctiy: " + GetComponent<Rigidbody>().velocity);
            playerMvmnt.rb.AddForce(moveX, 0f, moveZ);

        }
        if (collisionInfo.collider.tag == "end")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        if (collisionInfo.collider.tag == "axe")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        if (collisionInfo.collider.tag == "hammer")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
