using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Character {

    public GameObject arrow;

	void Start () {
		
	}
	
	void Update () {

        Shooting();

	}

    private float chargeTime;

    private void Shooting() {

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            chargeTime += 1 * Time.deltaTime;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            arrow.GetComponent<Arrow>().ArrowShot(chargeTime);
        }

    }
}