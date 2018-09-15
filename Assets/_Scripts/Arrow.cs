using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {

    private Archer a;
    private Rigidbody rb;
    public float force;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        a = GameObject.FindGameObjectWithTag("Archer").GetComponent<Archer>();
        rb.AddForce(Vector3.forward * force * a.chargeTime, ForceMode.Impulse);
    }

}