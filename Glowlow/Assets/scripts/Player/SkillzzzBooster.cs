﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillzzzBooster : MonoBehaviour
{


	[Header("Levels")]
	public float [] speedBoosterLevel;
	private int currentSpeedBoosterLevelIndex = 0;
	[Space(10)]
	public float [] lightBoosterLevel;
	private int currentLightBoosterLevelIndex = 0;
	[Space(10)]
	public float [] mapBoosterLevel;
	private int currentMapBoosterLevelIndex = 0;
	[Space(10)]


	//public float speedBoosterLevel[currentSpeedBoosterLevelIndex] = 5.0f;
	public float speedBoostCost = 1f;
	public float mapCost = 1f;

	private bool showMap = false;

	private Move mv;
	private Energy pe;
	private MiniMap mm;
	private HUDManager hm;
	private ViewSwitch vs;

	double lastTimeToggledHUD;

	bool HUDon = false;
	bool MAPon = false;
	bool speedBoosterOn = false;

	void Start ()
	{
		mv = gameObject.GetComponent<Move> ();
		pe = (Energy)GetComponent (typeof(Energy));
		mm = (MiniMap)transform.Find ("Map").GetComponent<MiniMap> ();
		hm = (HUDManager)transform.Find ("HUD").GetComponent<HUDManager> ();
		vs = (ViewSwitch)transform.GetComponent<ViewSwitch> ();

	}
	
	// Update is called once per frame
	void Update ()
	{
		//SPEEDBOOST
		if (Input.GetButtonDown ("X360_X") || Input.GetKeyDown (KeyCode.LeftShift)) { 
			pe.LooseEnergy (speedBoostCost * Time.deltaTime);
			speedBoosterOn = true;
		} 
		if (Input.GetButtonUp ("X360_X") || Input.GetKeyUp (KeyCode.LeftShift)) { 
			speedBoosterOn = false;
		}


		//HUD
		if ((Input.GetButton("X360_B") || Input.GetKey(KeyCode.R)) && lastTimeToggledHUD + .3 < Time.realtimeSinceStartup &&  vs.GetStatus() == Views.EXPLORE) {
			HUDon = !HUDon;
			hm.ToggleHUD ();
			lastTimeToggledHUD = Time.realtimeSinceStartup;
		}
		//MAP
		if ((Input.GetKeyDown (KeyCode.Tab) || Input.GetButtonDown ("X360_Y")) && lastTimeToggledHUD + .3 < Time.realtimeSinceStartup &&  vs.GetStatus() == Views.EXPLORE) {
			MAPon = !MAPon;
			mm.ToggleMap ();
			lastTimeToggledHUD = Time.realtimeSinceStartup;
			pe.LooseEnergy (mapCost * Time.deltaTime);
		}


		Debug.Log ("SpeedboostOn: " + speedBoosterOn);
		if ((MAPon || HUDon)) {
			mv.SetCurrentSpeed (0);
		}else if(speedBoosterOn){
			mv.SetCurrentSpeed (speedBoosterLevel[currentSpeedBoosterLevelIndex]);
		}else {
			mv.SetCurrentSpeed ();
		}

		// get level index
		if(GameObject.Find("HUDSpeedBars") != null){
			currentSpeedBoosterLevelIndex = GameObject.Find("HUDSpeedBars").GetComponent<SkillLevels>().level;
		}


	}


}
