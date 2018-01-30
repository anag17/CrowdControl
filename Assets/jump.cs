using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {

	public enum MOOD { Calm = 0, Agitated = 1, Hostile = 2 };
	[SerializeField] private MOOD crowdMood;
	[SerializeField] private int jumpHeight;
	[SerializeField] private int jumpProbability;
	private bool jumping = false;

	// Update is called once per frame
	void Update () {
		if (!jumping) {
			int random = Random.Range(0, 100 - jumpProbability);
			if (random == 0) {
				gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * (jumpHeight * (int)crowdMood));
				jumping = true;
			}
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		jumping = false;
	}
}
