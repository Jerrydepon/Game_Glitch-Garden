﻿using UnityEngine;
using System.Collections;

public class TestPlayerPrefs : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print (PlayerPrefsManager.GetMasterVolume());
		PlayerPrefsManager.SetMasterVolume(0.3f);
		print (PlayerPrefsManager.GetMasterVolume());		
		
		print (PlayerPrefsManager.IsLevelUnlocked(2));
		PlayerPrefsManager.UnlockeLevel(2);
		print (PlayerPrefsManager.IsLevelUnlocked(2));
		
		print (PlayerPrefsManager.GetDifficulty());
		PlayerPrefsManager.SetDifficulty(0.2f);
		print (PlayerPrefsManager.GetDifficulty());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
