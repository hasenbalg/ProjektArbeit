using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillzzzBooster : MonoBehaviour
{

	public float speedBoostVelocity = 5.0f;
	public float speedBoostCost = 1f;
	public float mapCost = 1f;

//	public Camera mapCam;

	private float defaultSpeed;
	private MoveWASD moveWASD;
	private bool controller_X_pressed = false, controller_Y_pressed = false;
	private bool showMap = false;

	PlayerEnergy pe;
	MiniMap mm;

	// Use this for initialization
	void Start ()
	{
		moveWASD = gameObject.GetComponent<MoveWASD> ();
		defaultSpeed = moveWASD.speed;

		pe = (PlayerEnergy)GetComponent (typeof(PlayerEnergy));

		mm = (MiniMap)transform.FindChild ("Map").GetComponent<MiniMap> ();
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
			mm.ToggleMap ();
			pe.LooseEnergy (mapCost);
		}

		if (Input.GetButtonUp ("X360_Y")) {
			mm.ToggleMap ();
		}


		//TAB KEY
		if (Input.GetKeyDown (KeyCode.Tab)) {
			mm.ToggleMap ();
			pe.LooseEnergy (mapCost);
		}
		if (Input.GetKeyUp (KeyCode.Tab)) {
			mm.ToggleMap ();
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
