using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inRange : MonoBehaviour {


	// Use this for initialization
	public Canvas uielement;
	Animator anim;

	void Awake(){
		anim = uielement.GetComponent<Animator> ();
	}


	void OnTriggerEnter(Collider other){
		anim.SetBool ("InRange", true);
	}

	void OnTriggerExit(){
		anim.SetBool ("InRange", false);
	}
	

}
