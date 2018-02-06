using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdSpawner : MonoBehaviour {

	[SerializeField] private GameObject townsPeople;
	[SerializeField] private Material[] materials;
    [SerializeField] private int sizeX = 15;
	[SerializeField] private int sizeZ = 15;
	[SerializeField] private int numPeople = 20;
    [SerializeField] private float spacing = 1.0f;

	// Use this for initialization
	void Start () {
		TownpersonSpawn ();
	}

	private void TownpersonSpawn () {
        Vector3 location = GetComponent<Transform>().position;
        bool[,] openLocation = new bool[sizeX, sizeZ];
        int[] focalPoint = { 0, sizeZ / 2 };
        int numMade = 0;

        if (numPeople > sizeX * sizeZ) { numPeople = sizeX * sizeZ; }

        for (int i = 0; i < sizeX; i++) {
            for (int j = 0; j < sizeZ; j++) {
                openLocation[i, j] = true;
            }
        }

		
		while (numMade < numPeople) {
            for (int i = 0; i < sizeX; i++) {
                for (int j = 0; j < sizeZ; j++) {
                    if (openLocation[i, j]) {
                        float chance = 1.0f / ((i - focalPoint[0]) * (i - focalPoint[0]) + (j - focalPoint[1]) * (j - focalPoint[1]));
                        chance *= chance;
                        
                        
                        if (Random.Range(0.0f, 1.0f) <= chance) {
                            float randX = Random.Range(-spacing / 2, spacing / 2);
                            float randZ = Random.Range(-spacing / 2, spacing / 2);
							GameObject.Instantiate(townsPeople, new Vector3(location.x + randX + spacing * i, location.y, location.z + randZ + spacing * j), Quaternion.identity).GetComponent<Renderer>().material = materials[numMade % materials.Length];;
                            openLocation[i, j] = false;
                            numMade++;
                        }

                        if (numMade == numPeople) { break; }
                    }

                    if (numMade == numPeople) { break; }
                }
            }

            
			
		}
	}
}
