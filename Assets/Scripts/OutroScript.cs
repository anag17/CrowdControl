using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OutroScript : MonoBehaviour {

	Text [] outroText;
	public float fadeInLineTime = 2.5f;
	public float fadeAllTime = 1f;
	public float readTime = 3.75f;
	public string scene = "StartMenu"; // add scene variable to load next element AM
	IEnumerator fadeTextInCoroutine;

	void Start () {
		outroText = GetComponentsInChildren<Text> ();

		for (int i = 0; i < outroText.Length; i++) {
			outroText[i].CrossFadeAlpha(0f, 0f, false);
		}

		InitializeText ();
		fadeTextInCoroutine = FadeTextIn ();
		StartCoroutine (fadeTextInCoroutine);
	}

	IEnumerator FadeTextIn() {
		// Outro text fades in
		for (int i = 0; i < outroText.Length; i++) {
			if (i > 0 && i % 2 == 0) {
				outroText [i - 2].CrossFadeAlpha (0f, fadeAllTime, false);
				outroText [i - 1].CrossFadeAlpha (0f, fadeAllTime, false);
				yield return new WaitForSeconds (1f);
			}
			outroText[i].CrossFadeAlpha (1f, fadeInLineTime, false);
			yield return new WaitForSeconds (readTime);
		}
			
	}

	void InitializeText() {
		outroText [0].text = "John Wilme and Jane Whitehouse are just two of the scores of Bostonians who gave their depositions...";
		outroText [1].text = "\n\n\n...but already they suggest two very different narratives.";
		outroText [2].text = "One suggests the soldiers itched for Bostonian’s blood...";
		outroText [3].text = "\n\n\n...the other claims the  townspeople attacked the soldiers in a riot.";
		outroText [4].text = "The depositions from the Boston Massacre are rife with conflicting information and differing perspectives…";
		outroText [5].text = "\n\n\n...and it’s the job of the historian to grapple with these differences.";
		outroText [6].text = "You have just played a demo with only two points of view.";
		outroText [7].text = "\n\n\nThe full game will have at least fifteen.";
		outroText [8].text = "When you return to the Townhouse as you just did, you will be asked to answer a number of questions:";
		outroText [9].text = "\n\nHow big was the crowd in front of the Townhouse?\n\nWhere was Captain Preston standing?\n\nDid he order fire?\n\nWhat were the townspeople throwing, if anything? \n";
		outroText [10].text = "You will have to return to your journal and use your notes and the depositions you collected to answer.";
		outroText [11].text = "\n\n\nYou will then see a recreation based on  your responses of what happened the evening of March 5, 1770.";
		outroText [12].text = "Thank you for playing";
		outroText [13].text = "\n\n\nWitness to the Revolution.";
		outroText [14].text = "Press the Space Bar to restart the game";
	}

	void Update() {
		// fast forward through text with arrow key
		if (Input.GetKey ("right")) {
			StopCoroutine (fadeTextInCoroutine);
			StartCoroutine (fadeTextInCoroutine);
		}

		// Restart the game by triggering first scene
		if (Input.GetKey (KeyCode.Space)) {
			SceneManager.LoadScene (scene);
		}
	}
}