using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Character {

    [Header("Shooting Related")]
    public GameObject arrow;
    public float maxCharge;

    public float chargeTime;
    public Transform arrowSpawn;
	
	void Update () {

        if (!isLocalPlayer)
        {
            return;
        }

        Shooting();
        Movement();

	}

    private void Shooting() {

        if (Input.GetButtonDown("Fire1"))
        {
            if (chargeTime <= maxCharge)
            {
                chargeTime += 1 * Time.deltaTime;
            }
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            Instantiate(arrow,arrowSpawn.position,Quaternion.identity);
            chargeTime = 0;
        }

    }
}