using UnityEngine;
using System.Collections;

//[RequireComponent(typeof(CharacterController))]

public class Controllers : MonoBehaviour {

	public float moveSpeed = 0f;
	public float turnSpeed = 20f;

	private float constSpeed = 2f;

	// Use this for initialization
	void Start () 
	{
	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Rotate (Vector3.forward * -turnSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Rotate (Vector3.forward * turnSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (Vector3.right * -turnSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (Vector3.right * turnSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.Space)) {
			if (moveSpeed < 240f) {
				moveSpeed += constSpeed;
				constSpeed += 2f;
			} else
				moveSpeed = 240f;
		} else {
			if (moveSpeed > 0f) {
				moveSpeed -= constSpeed;
				constSpeed -= 2f;
			} else
				moveSpeed = 0f;
		}
		transform.Translate (Vector3.up * moveSpeed * Time.deltaTime);
	}
}