using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SetColor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Renderer rend = GetComponent<Renderer>();
		rend.material.shader = Shader.Find("Standard");
		rend.material.EnableKeyword("_METALLICGLOSSMAP");			
		rend.material.SetColor("_Color", Color.red);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
