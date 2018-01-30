using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Specialized;

public class Spawner : MonoBehaviour {

	public int captainLocation = 0;
	public GameObject preston;

//	[SerializeField] private GameObject townsPeople;
//	[SerializeField] private int spacing = 1;
//	[SerializeField] private int sizeZ = 15;
//	[SerializeField] private int numPeople = 20;

	// Use this for initialization
	void Start () {
		CaptainSpawn ();
		//TownpersonSpawn ();
	}

	private void CaptainSpawn () {
		Vector3 location = GetComponent<Transform>().position;
		if (captainLocation == 0) {
			// instantiate preston in front of soldiers
			GameObject.Instantiate (preston, new Vector3 (location.x + 4, location.y, location.z), Quaternion.identity);
		} else if (captainLocation == 1) {
			// instantiate preston to side (left) of soldiers
			GameObject.Instantiate (preston, new Vector3 (location.x, location.y, location.z + 8), Quaternion.identity);
		} else if (captainLocation == 2) {
			// instantiate preston to side (right) of soldiers
			GameObject.Instantiate (preston, new Vector3 (location.x, location.y, location.z - 8), Quaternion.identity);
		}
		else {
			// instantiate preston behind soldiers
			GameObject.Instantiate (preston, new Vector3(location.x - 4, location.y, location.z), Quaternion.identity);
		}
	}

//	private void TownpersonSpawn () {
//		int rowNum = sizeZ / (3 * spacing);
//		Vector3 location = GetComponent<Transform>().position + new Vector3(10, 0 , -1 * rowNum / 2);
//		int numMade = 0;
//		float previousZ = location.z + location.z + (numMade / rowNum) + spacing;
//		while (numMade < numPeople) {
//			GameObject.Instantiate (townsPeople, new Vector3(location.x + (numMade % rowNum), location.y, previousZ + (numMade / rowNum) + spacing), Quaternion.identity);
//			numMade++;
//		}
//		
//	}	
}
