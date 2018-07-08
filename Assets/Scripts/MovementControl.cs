using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void Move(string movement) {
		float x, y;
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
		transform.position += new Vector3(x, 0, y);
	}

}
