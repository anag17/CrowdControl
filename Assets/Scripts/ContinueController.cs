using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class ContinueController : MonoBehaviour {

	public GameObject continueButton;
	string dbURL = "http://localhost/bostonmassacre/dataPost.php";
	public enum POSITION { Front = 0, Back = 1, Left = 2, Right = 3 };
	public enum MOOD { Calm = 0, Agitated = 1, Hostile = 2 };
	public string nextScene;


	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnContinueClicked () {
		StartCoroutine(Upload());
		SceneManager.LoadScene(nextScene);
	}

	IEnumerator Upload()
	{
		int mood = (int)CrowdVars.GetMood();
		int crowdSize = CrowdVars.GetCrowdSize();
		int captainPosition = (int)CrowdVars.GetCaptainPosition ();
		WWWForm form = new WWWForm ();
		form.AddField ("mood", mood);
		form.AddField ("crowdSize", crowdSize);
		form.AddField ("captainPosition", captainPosition);

		using (UnityWebRequest www = UnityWebRequest.Post(dbURL, form))
		{
			yield return www.SendWebRequest();

			if (www.isNetworkError || www.isHttpError)
			{
				Debug.Log(www.error);
			}
			else
			{
				Debug.Log("Form upload complete!");
			}
		}
	}

}
