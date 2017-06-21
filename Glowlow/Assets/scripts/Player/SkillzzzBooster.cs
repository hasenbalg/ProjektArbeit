using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillzzzBooster : MonoBehaviour
{

	public float speedBoostVelocity = 5.0f;
	public float speedBoostCost = 1f;
	public float mapCost = 1f;

	private bool showMap = false;

	private Move mv;
	private Energy pe;
	private MiniMap mm;
	private HUDManager hm;
	private ViewSwitch vs;

	double lastTimeToggledHUD;

	void Start ()
	{
		mv = gameObject.GetComponent<Move> ();
		pe = (Energy)GetComponent (typeof(Energy));
		mm = (MiniMap)transform.FindChild ("Map").GetComponent<MiniMap> ();
		hm = (HUDManager)transform.FindChild ("HUD").GetComponent<HUDManager> ();
		vs = (ViewSwitch)transform.GetComponent<ViewSwitch> ();

	}
	
	// Update is called once per frame
	void Update ()
	{
		//SPEEDBOOST
		if (Input.GetButtonDown ("X360_X") || Input.GetKeyDown (KeyCode.LeftShift)) { 
			ToggleSpeedBoost ();
			pe.LooseEnergy (speedBoostCost * Time.deltaTime);
		} 
		if (Input.GetButtonUp ("X360_X") || Input.GetKeyUp (KeyCode.LeftShift)){
			ToggleSpeedBoost ();
		}


		//MAP
		if (Input.GetKeyDown (KeyCode.Tab) || Input.GetButtonDown ("X360_Y")) {
			mm.ToggleMap ();
			pe.LooseEnergy (mapCost * Time.deltaTime);
		}

		if (Input.GetKeyUp (KeyCode.Tab) || Input.GetButtonUp ("X360_Y")) {
			mm.ToggleMap ();
		}


		//HUD
		if ((Input.GetButton("X360_B") || Input.GetKey(KeyCode.R)) && lastTimeToggledHUD + .3 < Time.realtimeSinceStartup &&  vs.GetStatus() == Views.EXPLORE) {
			hm.ToggleHUD ();
			mv.ToggleFreeze ();
			lastTimeToggledHUD = Time.realtimeSinceStartup;
		}
	}



	private void ToggleSpeedBoost ()
	{
		mv.ToggleFaster (speedBoostVelocity);
	}
}
