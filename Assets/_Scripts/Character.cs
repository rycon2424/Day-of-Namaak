using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Character : NetworkBehaviour {

    [Header("Base Statistics")]
    public float health;
    public float stamina;

    [Header("Movement")]
	public float speed = 10f;

	[Header("Jump")]
	public bool jumpUse = true;
	public float forceConst;
	public Rigidbody selfRigidbody;

	void Start () 
	{
        if (isLocalPlayer) {
			this.transform.GetChild (0).gameObject.GetComponent<Camera> ().enabled = true;
			this.transform.GetChild (0).gameObject.GetComponent<AudioListener> ().enabled = true;
		} else {
			this.transform.GetChild (0).gameObject.GetComponent<Camera> ().enabled = false;
			this.transform.GetChild (0).gameObject.GetComponent<AudioListener> ().enabled = false;
		}
		selfRigidbody = GetComponent<Rigidbody> ();
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

    public void Movement()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        float translation = Input.GetAxis("Vertical") * speed;
        float strafe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        strafe *= Time.deltaTime;

        transform.Translate(strafe, 0, translation);

        if (Input.GetKey(KeyCode.Space) && jumpUse == true)
        {
            selfRigidbody.AddForce(0, forceConst, 0, ForceMode.Impulse);
            StartCoroutine(Cooldown());
            jumpUse = false;
        }
    }

    IEnumerator Cooldown()
	{
		yield return new WaitForSeconds (2f);
		jumpUse = true;
	}

    // dat je eigen mesh niet kan zien
	/*public override void OnStartLocalPlayer()
	{
		GetComponentInChildren<SkinnedMeshRenderer> ().enabled = false;
	}*/
}
