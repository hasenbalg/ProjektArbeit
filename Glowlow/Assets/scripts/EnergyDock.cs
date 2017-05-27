using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyDock : MonoBehaviour {

	public float timeToFillUp = 10f;
	private float intitialTime;
	private GameObject indicator;
	private GameObject player;


	// Use this for initialization
	void Start () {
		intitialTime = timeToFillUp;
		player = GameObject.Find ("Player");
		indicator = transform.FindChild("Indicator 1").gameObject;
		//Debug.Log ( transform.localScale);

	}
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance(player.transform.position, transform.position) < transform.localScale.x){
			timeToFillUp -= Time.deltaTime;
			indicator.transform.localScale = new Vector3(1,(intitialTime - timeToFillUp) / intitialTime, 1);
		}
	}


}
