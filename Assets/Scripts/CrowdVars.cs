﻿using UnityEngine;
using UnityEngine.UI;

public static class CrowdVars {

    private static int crowdSize;
	public enum POSITION { Front = 0, Back = 1, Left = 2, Right = 3 };
    private static POSITION captainPosition;
	public enum MOOD { Calm = 0, Agitated = 1, Hostile = 2 };
	private static MOOD crowdMood;
	private static bool positionSet = false;
	private static bool moodSet = false;


	public static void SetCaptainPosition(POSITION position) {
		captainPosition = position;
	}

	public static POSITION GetCaptainPosition() {
		return captainPosition;
	}

	public static void SetMood(MOOD mood) {
		crowdMood = mood;
	}

	public static MOOD GetMood() {
		return crowdMood;
	}

	public static void SetCrowdSize(int size) {
		crowdSize = size;
	}

	public static int GetCrowdSize () {
		return crowdSize;
	}

	public static void SetPositionClicked () {
		positionSet = true;
	}

	public static void SetMoodClicked () {
		moodSet = true;
	}

	public static bool CanContinue () {
		return (positionSet && moodSet);
	}
}
