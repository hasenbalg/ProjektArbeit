using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillzzzBooster : MonoBehaviour
{

	public float speedBoostVelocity = 5.0f;
	public float speedBoostCost = 1f;
	public float mapCost = 1f;

	public Camera mapCam;

	private float defaultSpeed;
	private MoveWASD moveWASD;
	private bool controller_X_pressed = false, controller_Y_pressed = false;
	private bool showMap = false;

	PlayerEnergy pe;

	// Use this for initialization
	void Start ()
	{
		moveWASD = gameObject.GetComponent<MoveWASD> ();
		defaultSpeed = moveWASD.speed;

		pe = (PlayerEnergy)GetComponent (typeof(PlayerEnergy));

		mapCam.enabled = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//SPEEDBOOST
		if (Input.GetKeyDown (KeyCode.LeftShift)) { 
			ToggleSpeedBoost ();
			pe.LooseEnergy (speedBoostCost);
		} 
		if (Input.GetKeyUp (KeyCode.LeftShift)){
			ToggleSpeedBoost ();
		}

		//Controller
		if (Input.GetButtonDown ("X360_X")) {
			ToggleSpeedBoost ();
			pe.LooseEnergy (speedBoostCost);
		}

		if (Input.GetButtonUp ("X360_X")) {
			ToggleSpeedBoost ();
		}


		//MAP
		//Controller
		if (Input.GetButtonDown ("X360_Y")) {
			ToggleMapCam ();
			pe.LooseEnergy (mapCost);
		}

		if (Input.GetButtonUp ("X360_Y")) {
			ToggleMapCam ();
		}

       
		//TAB KEY
		if (Input.GetKeyDown (KeyCode.Tab)) {
			ToggleMapCam ();
			pe.LooseEnergy (mapCost);
		}
		if (Input.GetKeyUp (KeyCode.Tab)) {
			ToggleMapCam ();
		}
        
	}

	private void ToggleMapCam ()
	{
		if (mapCam.enabled) {
			mapCam.enabled = false;
		} else {
			mapCam.enabled = true;
		}
	}

	private void ToggleSpeedBoost ()
	{
		if (moveWASD.speed == defaultSpeed) {
			moveWASD.speed = defaultSpeed + speedBoostVelocity;
		} else {
			moveWASD.speed = defaultSpeed;
		}
	}
}
