using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour {

    public GameObject crowdSlider;
    public GameObject currentDisplay;
    public InputField inputField;
    public GameObject inputText;
    //public GameObject CrowdVars;
    public int increment;

	// Use this for initialization
	void Start () {
        crowdSlider.GetComponent<Slider>().value = 10;
        currentDisplay.GetComponent<Text>().text = "50";
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void UpdateSliderValue() {
        int val = (int)crowdSlider.GetComponent<Slider>().value * increment;
        currentDisplay.GetComponent<Text>().text = val.ToString();
        CrowdVars.SetCrowdSize(val);
    }

    public void UpdateSliderFromInput() {
        int val;
        try
        {
            val = int.Parse(inputText.GetComponent<Text>().text) / increment;
        }
        catch {
            // Show some error
            return;
        }

        if (val >= 0)
        {
            crowdSlider.GetComponent<Slider>().value = val;
            UpdateSliderValue();
            inputField.Select();
            inputField.text = "";
        }
    }
}
