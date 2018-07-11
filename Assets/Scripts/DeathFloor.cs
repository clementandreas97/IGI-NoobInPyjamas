using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathFloor : MonoBehaviour {

	private LevelManager lvManager;

	// Use this for initialization
	void Start () {
		lvManager = GameObject.FindGameObjectWithTag("LevelManager").GetComponent<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider coll) {
		if (coll.tag == "Player") {
			Debug.Log ("dead");
			Time.timeScale = 0;
			lvManager.GetToast().Pop("REKT");
		}
	}
}
