using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : Character {
    
    void Start ()
    {
        selfRigidbody = GetComponent<Rigidbody>();
    }
	
	void Update ()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        
        Movement();
    }

}
