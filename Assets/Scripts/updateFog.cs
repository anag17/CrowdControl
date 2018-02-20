using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateFog : MonoBehaviour {
    [SerializeField] private bool isFoggy = false;
    [SerializeField] private float startDistance = 10;
    [SerializeField] private float endDistance = 100;
    [SerializeField] private Color fogColor = new Color(1, 1, 1, 1);

	// Use this for initialization
	void Start () {
        OnEnable();
	}

    private void OnEnable() {
        RenderSettings.fog = isFoggy;
        RenderSettings.fogMode = FogMode.Linear;
        RenderSettings.fogStartDistance = startDistance;
        RenderSettings.fogEndDistance = endDistance;
        RenderSettings.fogColor = fogColor;
    }
}
