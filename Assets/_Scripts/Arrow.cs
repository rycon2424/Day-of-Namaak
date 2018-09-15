using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {

    private Rigidbody rb;
    public float force;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * force, ForceMode.Impulse);
    }

}