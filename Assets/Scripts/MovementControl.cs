using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour {

	[SerializeField] float moveSpeed = 10.0f;
	[SerializeField] float jumpSpeed = 100.0f;
	[SerializeField] float nearTreshold = 0.02f;
	[SerializeField] float tileDistance = 0.5f;

	private LevelManager lvManager;
	private Vector3 target;
	private bool isMoving = false;

	// Use this for initialization
	void Start () {
		lvManager = GameObject.FindGameObjectWithTag("LevelManager").GetComponent<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!lvManager.IsMovable() && !transform.position.Equals(target) && isMoving) {
			transform.position = Vector3.Lerp (transform.position, target, moveSpeed * Time.deltaTime);
			if (NearTarget ()) {
				transform.position = target;
				lvManager.setMovable (true);
				isMoving = false;
			}
		}
	}

	public void Move(string movement) {
		isMoving = true;
		float x, y;
		if (lvManager.IsMovable()) {
			lvManager.setMovable (false);
			Jump ();

			switch (movement) {
			case "upright":
				{
					x = 1 + tileDistance;
					y = 0;
					break;
				}
			case "downright":
				{
					x = 0;
					y = -1 - tileDistance;
					break;
				}
			case "downleft":
				{
					x = 0;
					y = 1 + tileDistance;
					break;
				}
			case "upleft":
				{
					x = -1 - tileDistance;
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
		return (Vector3.Distance (transform.position, target) < nearTreshold);
	}

}
