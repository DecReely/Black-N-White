using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    public GameObject particle;
    public Rigidbody rb;
    public float jump = 500f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider player)
    {
        Instantiate(particle, transform.position, transform.rotation);
        rb.AddForce(0, jump, 0);
        Destroy(gameObject);
    }
}
