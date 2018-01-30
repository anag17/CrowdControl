using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Specialized;

public class CptSpawner : MonoBehaviour {

	public enum POSITIONS
	{
		Front = 0,
		Back = 1,
		Left = 2,
		Right = 3
	}

	[SerializeField] private POSITIONS prestonPosition;
	[SerializeField] private GameObject preston;

	// Use this for initialization
	void Start () {
		CaptainSpawn ();
	}

	private void CaptainSpawn () {
		Vector3 location = GetComponent<Transform>().position;
		switch (prestonPosition) {
			case POSITIONS.Front:
				GameObject.Instantiate (preston, new Vector3 (location.x + 4, location.y, location.z), Quaternion.identity);
				break;
			case POSITIONS.Right:
				GameObject.Instantiate (preston, new Vector3 (location.x, location.y, location.z + 8), Quaternion.identity);
				break;
			case POSITIONS.Left:
				GameObject.Instantiate (preston, new Vector3 (location.x, location.y, location.z - 8), Quaternion.identity);
				break;
			case POSITIONS.Back:
				GameObject.Instantiate (preston, new Vector3(location.x - 4, location.y, location.z), Quaternion.identity);
				break;
		}
	}
}
