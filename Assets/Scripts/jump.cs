using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {

	private int crowdMood;
	[SerializeField] private int jumpHeight;
	[SerializeField] private int jumpProbability;
	private bool jumping = false;
	private Transform trans;

	private void Start() {
		crowdMood = (int) CrowdVars.GetMood();
		trans = this.GetComponent<Transform>();
	}

	// Update is called once per frame
	void Update () {
		trans.rotation = new Quaternion(0, 0, 0, 0);
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