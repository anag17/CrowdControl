using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Specialized;

public class CptSpawner : MonoBehaviour {

	private int prestonPosition;
	[SerializeField] private GameObject preston;

	// Use this for initialization
	void Start () {
		prestonPosition = (int) CrowdVars.GetCaptainPosition();
		CaptainSpawn ();

	}

	private void CaptainSpawn () {
		Vector3 location = GetComponent<Transform>().position;
		switch (prestonPosition) {
			case 0:
				GameObject.Instantiate (preston, new Vector3 (location.x + 4, location.y, location.z), Quaternion.identity);
				break;
			case 1:
				GameObject.Instantiate (preston, new Vector3 (location.x, location.y, location.z + 8), Quaternion.identity);
				break;
			case 2:
				GameObject.Instantiate (preston, new Vector3 (location.x, location.y, location.z - 8), Quaternion.identity);
				break;
			case 3:
				GameObject.Instantiate (preston, new Vector3(location.x - 4, location.y, location.z), Quaternion.identity);
				break;
		}
	}
}
