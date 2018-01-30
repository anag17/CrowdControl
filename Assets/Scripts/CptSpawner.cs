using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Specialized;

public class CptSpawner : MonoBehaviour {

	public enum POSITION { Front, Back, Left, Right }

	[SerializeField] private POSITION prestonPosition;
	[SerializeField] private GameObject preston;

	// Use this for initialization
	void Start () {
		CaptainSpawn ();
	}

	private void CaptainSpawn () {
		Vector3 location = GetComponent<Transform>().position;
		switch (prestonPosition) {
			case POSITION.Front:
				GameObject.Instantiate (preston, new Vector3 (location.x + 4, location.y, location.z), Quaternion.identity);
				break;
			case POSITION.Right:
				GameObject.Instantiate (preston, new Vector3 (location.x, location.y, location.z + 8), Quaternion.identity);
				break;
			case POSITION.Left:
				GameObject.Instantiate (preston, new Vector3 (location.x, location.y, location.z - 8), Quaternion.identity);
				break;
			case POSITION.Back:
				GameObject.Instantiate (preston, new Vector3(location.x - 4, location.y, location.z), Quaternion.identity);
				break;
		}
	}
}
