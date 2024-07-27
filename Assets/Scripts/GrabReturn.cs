using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabReturn : MonoBehaviour
{
    private bool held;
    private Vector3 initialPos;
    private Quaternion initialRot;
    private Rigidbody rb;

    void Start()
    {
        held = false;
        initialPos = transform.position;
        initialRot = transform.rotation;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!held)
        {
            ReturnToInitialPos();
        }
    }

    public void PickUp()
    {
        held = true;
    }

    public void PutDown()
    {
        held = false;
    }

    void ReturnToInitialPos()
    {
        transform.position = initialPos;
        transform.rotation = initialRot;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
