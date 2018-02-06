using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {

	public enum MOOD { Calm = 0, Agitated = 1, Hostile = 2 };
	[SerializeField] private MOOD crowdMood;
	[SerializeField] private float jumpHeight;
	[SerializeField] private int jumpProbability;
	private bool jumping = false;
	private bool falling = false;

	void Start() {
		jumpHeight = jumpHeight * (int)crowdMood;
	}

	// Update is called once per frame
	void Update () {
		Vector3 position = gameObject.GetComponent<Transform>().position;
		if (!jumping) {
			int random = Random.Range(0, 100 - jumpProbability);
			if (random == 0) {
				jumping = true;
			}
		} else {
			if (!falling && position.y < jumpHeight) {
				gameObject.GetComponent<Rigidbody>().MovePosition(new Vector3(position.x, position.y + 0.1f, position.z));
			} else if (!falling && position.y >= jumpHeight) {
				falling = true;
			} else if (falling && position.y <= 1) {
				falling = false;
				jumping = false;
			} else {
				gameObject.GetComponent<Rigidbody>().MovePosition(new Vector3(position.x, position.y - 0.1f, position.z));
			}
		}
	}
}
