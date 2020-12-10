using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstMovement : MonoBehaviour
{
    //[SerializeField] float xSpeed = 1.5f;
    Rigidbody Rb;

    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        xMovement();
    }

    private void xMovement()
    {
        Rb.velocity = new Vector3(2f, 0, 0);
        StartCoroutine(stopMove());

    }

    IEnumerator stopMove()
    {
        yield return new WaitForSeconds(0.5f);
        Rb.velocity = new Vector3(-2f, 0, 0);
        //yield return new WaitForSeconds(8f);
        //Rb.velocity = new Vector3(2f, 0, 0);
    }

}
