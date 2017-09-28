using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Rigidbody rb; // a reference to the rigidbody attached to the player object
//	// Use this for initialization
	void Start () {
		// this will find and return a reference to the attached rigidbody if there is one 
		rb = GetComponent<Rigidbody> ();
	}

	// check for every frame for player input and then apply that input to player game object every frame as movement

	// Update is called once per frame
	// update is called before rendering a frame, and this is most of our game code will go

	void Update () {
	}

	// fixedUpdated is called just before performing any physics calculations, this is our physics code will go.
	void FixedUpdate () {
		// the float variables moveHorizontal and moveVertical record the input from horizontal and vertical axis, which are controlled by the keys on the keyboard
		// our game object uses a rigidbody and interacts with a physics engine, we will use this engine to add forces to the rigidbody and move the play objectin the scene
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		// add force to the rigidbody, it will move
		rb.AddForce (movement);

	}

}
