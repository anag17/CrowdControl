using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateFog : MonoBehaviour {
    public float startDistance = 10;
    public float endDistance = 100;
    public GameObject otherCamera;

	// Use this for initialization
	void Start () {
        OnEnable();
	}

    private void OnEnable() {
        RenderSettings.fogMode = FogMode.Linear;
        RenderSettings.fogStartDistance = startDistance;
        RenderSettings.fogEndDistance = endDistance;
    }
    
    void Update () {
        // Switch camera for testing purposes
        if (Input.GetKeyDown("c")) {
            otherCamera.SetActive(true);
            this.gameObject.SetActive(false);
        }
	}

    public void PlayAnimation() {
        GetComponent<Animator>().SetBool("ChoicesDone", true);
    }
}
