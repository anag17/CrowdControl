using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaptainController : MonoBehaviour {

	public GameObject frontButton;
	public GameObject behindButton;
	public GameObject leftButton;
	public GameObject rightButton;
	private GameObject lastClicked;
	private bool frontClicked;
	private bool behindClicked;
	private bool leftClicked;
	private bool rightClicked;
	private Color regularColor;


	// Use this for initialization
	void Start () {
		regularColor = frontButton.GetComponent<Image> ().color;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnFrontClicked () {
		if (!frontClicked) {
			frontClicked = true;
			behindClicked = false;
			leftClicked = false;
			rightClicked = false;

			frontButton.GetComponent<Image> ().color = Color.white;
			if (lastClicked != null) {
				lastClicked.GetComponent<Image> ().color = regularColor;
			}
			lastClicked = frontButton;

			CrowdVars.SetCaptainPosition (CrowdVars.POSITION.Front);
			CrowdVars.SetPositionClicked ();
		}
	}

	public void OnBehindClicked () {
		if (!behindClicked) {
			behindClicked = true;
			frontClicked = false;
			leftClicked = false;
			rightClicked = false;

			behindButton.GetComponent<Image> ().color = Color.white;
			if (lastClicked != null) {
				lastClicked.GetComponent<Image> ().color = regularColor;
			}
			lastClicked = behindButton;

			CrowdVars.SetCaptainPosition (CrowdVars.POSITION.Back);
			CrowdVars.SetPositionClicked ();
		}
	}

	public void OnLeftClicked () {
		if (!leftClicked) {
			leftClicked = true;
			frontClicked = false;
			behindClicked = false;
			rightClicked = false;

			leftButton.GetComponent<Image> ().color = Color.white;
			if (lastClicked != null) {
				lastClicked.GetComponent<Image> ().color = regularColor;
			}
			lastClicked = leftButton;

			CrowdVars.SetCaptainPosition (CrowdVars.POSITION.Left);
			CrowdVars.SetPositionClicked ();
		}
	}

	public void OnRightClicked () {
		if (!rightClicked) {
			rightClicked = true;
			frontClicked = false;
			behindClicked = false;
			leftClicked = false;

			rightButton.GetComponent<Image> ().color = Color.white;
			if (lastClicked != null) {
				lastClicked.GetComponent<Image> ().color = regularColor;
			}
			lastClicked = rightButton;

			CrowdVars.SetCaptainPosition (CrowdVars.POSITION.Right);
			CrowdVars.SetPositionClicked ();
		}
	}

}
