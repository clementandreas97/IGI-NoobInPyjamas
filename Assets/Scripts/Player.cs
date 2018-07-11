using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	[SerializeField] CanvasGroup actionButton;

	private LevelManager lvManager;
	private Transform target;

	// Use this for initialization
	void Start () {
		lvManager = GameObject.FindGameObjectWithTag("LevelManager").GetComponent<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void setTarget(Transform _target) {
		target = _target;
	}

	public void displayButton() {
		actionButton.alpha = 1.0f;
	}

	public void hideButton() {
		actionButton.alpha = 0.0f;
	}

	public void Warp() {
		if (lvManager.IsMovable()) {
			hideButton ();
			lvManager.setMovable (false);
			transform.position = target.position + new Vector3 (0, 0.7f, 0);
			lvManager.setMovable (true);
		}
	}
}
