using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {

    private Rigidbody rb;
    public float force;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void ArrowShot(float chargetime) {

        rb.AddForce(Vector3.forward * force * chargetime, ForceMode.Impulse);

    }

}