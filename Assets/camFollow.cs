using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollow : MonoBehaviour {


		public GameObject player;       //Public variable to store a reference to the player game object


		private Vector3 offset; 
	public Transform player1;//Private variable to store the offset distance between the player and camera
	public float height = 1f;
	public float distance = 2f;
	public float turnSpeed = 10f;
	private Vector3 offsetX;
	private Vector3 offsetY;


		// Use this for initialization
		void Start () 
		{
			//Calculate and store the offset value by getting the distance between the player's position and camera's position.
			offset = transform.position - player.transform.position;
		offsetX = new Vector3 (0, height, distance);
		offsetY = new Vector3 (0, 0, distance);
		}

		// LateUpdate is called after Update each frame
		void LateUpdate () 
		{
			// Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
			transform.position = player.transform.position + offset;
		offsetX = Quaternion.AngleAxis (Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offsetX;
		offsetY = Quaternion.AngleAxis (Input.GetAxis("Mouse Y") * turnSpeed, Vector3.right) * offsetY;
		transform.position = player1.position + offsetX + offsetY;
		transform.LookAt(player1.position);
		}
	}





