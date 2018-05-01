using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BehaviourScript : MonoBehaviour {

	public Image image;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

		if(DefaultTrackableEventHandler.isTracked) {
			// hide
			image.enabled = false;
		} else {
			image.enabled = true;
		}
	}
}
