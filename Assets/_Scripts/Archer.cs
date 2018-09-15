using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Character {

    [Header("Shooting Related")]
    public GameObject arrow;
    public float maxCharge;
    private float chargeTime;
    public Transform arrowSpawn;
	
	void Update () {

        Shooting();
        Movement();

	}

    private void Shooting() {

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (chargeTime <= maxCharge)
            {
                chargeTime += 1 * Time.deltaTime;
            }
        }
        else if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            Instantiate(arrow,arrowSpawn.position,Quaternion.identity);
            arrow.GetComponent<Arrow>().ArrowShot(chargeTime);
            chargeTime = 0;
        }

    }
}