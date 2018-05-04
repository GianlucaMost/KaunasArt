using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BehaviourScript : MonoBehaviour {

	public Image scanIntro;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if(DefaultTrackableEventHandler.isTracked) {
			// hide
			scanIntro.enabled = false;
		} else {
			// show
			// scanIntro.enabled = true;
		}
	}
}
