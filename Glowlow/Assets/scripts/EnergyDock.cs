using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyDock : MonoBehaviour {

	public float timeToFillUp = 10f;
	private float intitialTime;
	private GameObject indicator;
	private GameObject player;
	public bool isFilled = false;
	private float yOffset;

	public AudioClip fillUpSound;
	private AudioSource ac;

	// Use this for initialization
	void Start () {
		intitialTime = timeToFillUp;
		player = GameObject.Find ("Player");
		indicator = transform.FindChild("Indicator 1").gameObject;
		//Debug.Log ( transform.localScale);
		yOffset = indicator.transform.position.y;

		ac = GetComponent<AudioSource> ();
		ac.clip = fillUpSound;

		indicator.transform.localScale = new Vector3 (1, 0, 1);
		Vector3 level = indicator.transform.position;
		level.y = yOffset;
		indicator.transform.position = level;

	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (player.transform.position, transform.position) < transform.localScale.x) {
			timeToFillUp -= Time.deltaTime;
			indicator.transform.localScale = new Vector3 (1, (intitialTime - timeToFillUp) / intitialTime, 1);
			Vector3 level = indicator.transform.position;
			level.y = yOffset * (intitialTime - timeToFillUp) / intitialTime;
			indicator.transform.position = level;

			if (!ac.isPlaying && timeToFillUp > 0) {
				ac.Play ();

			}


		} else {
			if(ac.isPlaying){
				ac.Stop ();
			}
		}
		if (timeToFillUp <= 0) {
			timeToFillUp = 0;
			isFilled = true;
		} 
	}


}
