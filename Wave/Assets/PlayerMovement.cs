using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed = 50f;
	public bool grounded; // might not even need this
	private Rigidbody2D lifeGuard;

	// Use this for initialization
	void Start () {
		lifeGuard = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
	{
		float h = Input.GetAxis ("Horizontal");
	//	lifeGuard.AddForce ((Vector2.right * speed) * h);

		if (Input.GetKey (KeyCode.D)) {

			lifeGuard.AddForce ((Vector2.right * speed) * h);
		}

	}


}
