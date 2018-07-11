using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Toast : MonoBehaviour {

	[SerializeField] Text toastText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Pop(string text) {
		toastText.text = text;
		GetComponent<CanvasGroup> ().alpha = 1.0f;
	}

	public void Close() {
		GetComponent<CanvasGroup> ().alpha = 0.0f;
	}
		
}
