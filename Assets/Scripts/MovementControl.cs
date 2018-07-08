using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour {

	[SerializeField] float moveSpeed = 10.0f;
	[SerializeField] float jumpSpeed = 100.0f;
	[SerializeField] float nearTreshold = 0.02f;

	private bool movementLock = false;
	private Vector3 target;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (movementLock && !transform.position.Equals(target)) {
			transform.position = Vector3.Lerp (transform.position, target, moveSpeed * Time.deltaTime);
			if (NearTarget ()) {
				transform.position = target;
				movementLock = false;
			}
		}
	}

	public void Move(string movement) {
		float x, y;
		if (!movementLock) {
			movementLock = true;
			Jump ();

			switch (movement) {
			case "upright":
				{
					x = 1;
					y = 0;
					break;
				}
			case "downright":
				{
					x = 0;
					y = -1;
					break;
				}
			case "downleft":
				{
					x = 0;
					y = 1;
					break;
				}
			case "upleft":
				{
					x = -1;
					y = 0;
					break;
				}
			default:
				{
					x = 0;
					y = 0;
					break;
				}
			}
			target = transform.position + new Vector3 (x, 0, y);
		}

	}

	void Jump() {
		gameObject.GetComponent<Rigidbody>().AddForce (Vector3.up * jumpSpeed);
	}

	bool NearTarget() {
		return (Vector3.Distance (target, transform.position) < nearTreshold);
	}

}
