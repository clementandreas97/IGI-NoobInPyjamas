using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileTeleport : MonoBehaviour {

	[SerializeField] Transform target;

	private GameObject player;
	private LevelManager lvManager;

	// Use this for initialization
	void Start () {
		lvManager = GameObject.FindGameObjectWithTag("LevelManager").GetComponent<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision coll) {
		if (coll.gameObject.tag == "Player") {
			lvManager.GetPlayer ().setTarget (target);
			lvManager.GetPlayer ().displayButton ();
		}
	}

	void OnCollisionExit(Collision coll) {
		if (coll.gameObject.tag == "Player") {
			lvManager.GetPlayer ().hideButton ();
		}
	}

}
