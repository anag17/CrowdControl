using System.Collections;
using System.Collections.Generic;
//using System.Linq;
using UnityEngine;

public class CrowdSpawner : MonoBehaviour {

	[SerializeField] private GameObject townsPeople;
	[SerializeField] private int spacing = 1;
	[SerializeField] private int sizeZ = 15;
	[SerializeField] private int numPeople = 20;

	// Use this for initialization
	void Start () {
		TownpersonSpawn ();
	}

	private void TownpersonSpawn () {
		//Random rnd = new Random();
		int rowNum = sizeZ / (2 * spacing + 1);
		int numMade = 0;
		Vector3 location = GetComponent<Transform>().position;
		while (numMade < numPeople) {
//			int randX = rnd.Next (-spacing, spacing);
//			int randZ = rnd.Next (-spacing, spacing);
			int randX = Random.Range(-spacing, spacing);
			int randZ = Random.Range(-spacing, spacing);
			GameObject.Instantiate (townsPeople, new Vector3 (location.x + (numMade % rowNum) + randX, location.y, location.z + (numMade / rowNum) + randZ), Quaternion.identity);
			numMade++;
		}
	}	
}
