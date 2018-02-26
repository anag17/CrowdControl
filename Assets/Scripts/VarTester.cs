using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarTester : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log(CrowdVars.GetCaptainPosition());
		Debug.Log(CrowdVars.GetCrowdSize());
		Debug.Log(CrowdVars.GetMood());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
