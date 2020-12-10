using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstMovement : MonoBehaviour
{
    [SerializeField] float xSpeed = 1.2f;
    Rigidbody Rb;

    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Rb.velocity = new Vector3(xSpeed, 0f, 0f);
    }
}
