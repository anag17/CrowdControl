using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	public string scene;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) 
	{
		SceneManager.LoadSceneAsync(scene);
	}

	public void loadScene()
	{
		SceneManager.LoadSceneAsync(scene);
	}

}
