using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0,0,3);
    }

    void Update()
    {
        if(Input.GetKey("a"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-1,0,3);
        }
        else if(Input.GetKey("d"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(1,0,3);
        }
    }
}
