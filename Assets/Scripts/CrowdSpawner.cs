using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdSpawner : MonoBehaviour {

	[SerializeField] private GameObject townsPeople;
	[SerializeField] private int spacing = 1;
	[SerializeField] private int sizeZ = 15;
	[SerializeField] private int numPeople = 20;

	// Use this for initialization
	void Start () {
		
	}
	
	private void TownpersonSpawn () {
		//		int rowNum = sizeZ / (3 * spacing);
		//		Vector3 location = GetComponent<Transform>().position + new Vector3(10, 0 , -1 * rowNum / 2);
		//		int numMade = 0;
		//		float previousZ = location.z + location.z + (numMade / rowNum) + spacing;
		//		while (numMade < numPeople) {
		//			GameObject.Instantiate (townsPeople, new Vector3(location.x + (numMade % rowNum), location.y, previousZ + (numMade / rowNum) + spacing), Quaternion.identity);
		//			numMade++;
		//		}
		Vector3 location = GetComponent<Transform>().position + new Vector3(10, 0, -1 * rowNum / 2);
	}	
}
