using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstMovement : MonoBehaviour
{
    [SerializeField] float xSpeed = 1.5f;
    Rigidbody Rb;

    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Rb.velocity = new Vector3(xSpeed, 0f, 0f);

    }


    void OnTriggerEnter(Collider other)
    {
       
        if(other.gameObject.CompareTag("Wall"))
        {
            Rb.velocity = new Vector3(-xSpeed, 0f, 0f);
        }
        
    }
    /*private void onEnterCollision(Collision collision)
    {
        if(collision.gameObject.name == "Wall"){
            Rb.velocity = new Vector3(-xSpeed, 0f, 0f);
        }

    }*/

    
}
