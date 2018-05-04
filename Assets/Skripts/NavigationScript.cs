using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationScript : MonoBehaviour {

	public GameObject map;
	public GameObject scanner;
	public GameObject profile;
	public Camera cam;

	public void switchToMap() {
		map.SetActive (true);
		scanner.SetActive (false);
		profile.SetActive (false);
		cam.enabled = false;
	}

	public void switchToScanner() {
		map.SetActive (false);
		scanner.SetActive (true);
		profile.SetActive (false);
		cam.enabled = true;
	}

	public void switchToProfile() {
		map.SetActive (false);
		scanner.SetActive (false);
		profile.SetActive (true);
		cam.enabled = false;
	}

	// Use this for initialization
	void Start () {
		map.SetActive (true);
		scanner.SetActive (false);
		profile.SetActive (false);
		cam.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}