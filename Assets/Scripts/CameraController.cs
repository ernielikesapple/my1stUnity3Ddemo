using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	// for our offset value, we will take the current transform postion, and 
	// substract the transform postion of the player to find the difference between the two.

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	// LateUpdate is guaranteed to run after all items have been processed in update. 
	void LateUpdate () {
		// as we move our player with the controls on the keyboard, that each frame before displaying what the camera can see, 
		// the camera is moved in to a new position aligned with the player object
		transform.position = player.transform.position + offset;
	}
}
