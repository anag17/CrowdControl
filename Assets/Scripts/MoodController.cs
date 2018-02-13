using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoodController : MonoBehaviour {

	public GameObject calmButton;
	public GameObject agitatedButton;
	public GameObject hostileButton;
	private GameObject lastClicked;
	private bool calmClicked;
	private bool agitatedClicked;
	private bool hostileClicked;
	private Color regularColor;

	// Use this for initialization
	void Start () {
		regularColor = hostileButton.GetComponent<Image> ().color;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCalmClicked () {
		if (!calmClicked) {
			calmClicked = true;
			agitatedClicked = false;
			hostileClicked = false;

			calmButton.GetComponent<Image> ().color = Color.white;
			if (lastClicked != null) {
				lastClicked.GetComponent<Image> ().color = regularColor;
			}
			lastClicked = calmButton;

			CrowdVars.SetMood (CrowdVars.MOOD.Calm);
		}
	}

	public void OnAgitatedClicked () {
		if (!agitatedClicked) {
			agitatedClicked = true;
			calmClicked = false;
			hostileClicked = false;

			agitatedButton.GetComponent<Image> ().color = Color.white;
			if (lastClicked != null) {
				lastClicked.GetComponent<Image> ().color = regularColor;
			}
			lastClicked = agitatedButton;

			CrowdVars.SetMood (CrowdVars.MOOD.Agitated);
		}
	}

	public void OnHostileClicked () {
		if (!hostileClicked) {
			hostileClicked = true;
			calmClicked = false;
			agitatedClicked = false;

			hostileButton.GetComponent<Image> ().color = Color.white;
			if (lastClicked != null) {
				lastClicked.GetComponent<Image> ().color = regularColor;
			}
			lastClicked = hostileButton;

			CrowdVars.SetMood (CrowdVars.MOOD.Hostile);
		}
	}
}
