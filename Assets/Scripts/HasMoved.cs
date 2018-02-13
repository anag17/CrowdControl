using UnityEngine;
using System.Collections;

public class HasMoved : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Awake () {
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void FixedUpdate () {

		if (Input.GetAxis ("Horizontal") != 0.0f || Input.GetAxis ("Vertical") != 0.0f) {
			anim.SetTrigger ("moved");
		}
		if (Input.GetKeyDown ("tab")) {
			anim.SetTrigger ("tabbed");
		}

		if (anim.GetBool ("InRange")) {
		}

		if (Input.GetKeyDown ("e") && anim.GetBool("InRange")) {
			anim.SetTrigger ("pressedE");
		}
	}
}
