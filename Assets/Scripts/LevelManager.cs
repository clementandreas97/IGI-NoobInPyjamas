using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	[SerializeField] GameObject toast;
	[SerializeField] GameObject player;

	private bool movable = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public Toast GetToast() {
		return toast.GetComponent<Toast>();
	}

	public Player GetPlayer() {
		return player.GetComponent<Player>();
	}

	public bool IsMovable() {
		return movable;
	}

	public void setMovable(bool _movable) {
		movable = _movable;
	}

}
