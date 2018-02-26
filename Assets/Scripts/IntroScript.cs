using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroScript : MonoBehaviour {

	Text [] introText;
	Image [] coffins;
	public float fadeInLineTime = 2.5f;
	public float fadeAllTime = 1f;
	public float readTime = 3.75f;
	public float transitionTime = 1f;
	public string scene; // add scene variable to load next element AM

	void Start () {
		introText = GetComponentsInChildren<Text> ();
		coffins = GetComponentsInChildren<Image> ();

		for (int i = 0; i < 10; i++) {
			introText[i].CrossFadeAlpha(0f, 0f, false);
		}
		coffins [0].CrossFadeAlpha (0f, 0f, false);
		coffins [1].CrossFadeAlpha (0f, 0f, false);

		InitializeText ();

		StartCoroutine (FadeTextIn());
	}

	IEnumerator FadeTextIn() {
		// Coffins, intro text fade in ("On the evening..." to "what happened that night...")
		for (int i = 0; i < 6; i++) {
			introText[i].CrossFadeAlpha (1f, fadeInLineTime, false);
			if (i == 1 || i == 2) {
				coffins [(i - 1)].CrossFadeAlpha (1f, readTime, false); // "Four men died" coffin fade-in, "One will not..." coffin fade-in
			}
			yield return new WaitForSeconds (readTime);
		}


		// Intro text, then coffins, fade out
		for (int i = 0; i < 9; i++) {
			introText [i].CrossFadeAlpha (0f, fadeAllTime, false);
		}
		for (int i = 0; i < 2; i++) {
			coffins [i].CrossFadeAlpha (0f, fadeAllTime, false);
		}

		// "Whom do you believe" fade in, fade out
		yield return new WaitForSeconds (transitionTime);
		introText [6].CrossFadeAlpha (1f, fadeInLineTime, false); // "Whom do you believe?"
		yield return new WaitForSeconds (readTime);
		introText [6].CrossFadeAlpha (0f, fadeAllTime, false);

		// Instructions fade in
		yield return new WaitForSeconds (transitionTime);
		introText [7].CrossFadeAlpha (1f, fadeInLineTime, false); // "The Town of Boston has asked you..."
		yield return new WaitForSeconds (readTime);
		introText [8].CrossFadeAlpha (1f, fadeInLineTime, false); // "Take at least 3 depositions..."
		yield return new WaitForSeconds (readTime);
		introText [7].CrossFadeAlpha (0f, fadeAllTime, false); // "Take at least 3 depositions..."
		introText [8].CrossFadeAlpha (0f, fadeAllTime, false); // "Take at least 3 depositions..."
		yield return new WaitForSeconds (readTime);
		SceneManager.LoadSceneAsync(scene);
	}

	void InitializeText() {
		introText [0].text = "On the evening of March 5th, 1770, soldiers from the 29th regiment shot eleven men.";
		introText [1].text = "\n\n\nFour men died.                                           ";
		introText [2].text = "\n\n\n                                 One will not live long.";
		introText [3].text = "\n\n\n\n\n\nThe people of Boston are in shock.";
		introText [4].text = "\n\n\n\n\n\n\n\n\nEveryone is talking about what happened that night...";
		introText [5].text = "\n\n\n\n\n\n\n\n\n\n\n\n...and everyone saw something different.";
		introText [6].text = "Whom do you believe?";
		introText [7].text = "The Town of Boston has asked you to find and interview witnesses.";
		introText [8].text = "\n\n\nTake at least 3 depositions and then return to the Town House.";
	}
}
