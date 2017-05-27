﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnergy : MonoBehaviour {


	public Light playerLight;
	private float fullEnergy;
	public float energy = 1000f;
	private float fullIntensity;


    void Start(){
		fullEnergy = energy;
		fullIntensity = playerLight.intensity;
	}


	public void LooseEnergy (float damage) {
		energy -= damage;
		playerLight.intensity = fullIntensity * (energy / fullEnergy);
		if (energy == 0) {
			Destroy (gameObject);
		}
	}

	public void GainEnergy(){
//		fill up to 100%
		Debug.Log("Energy to gain: " + (energy - fullEnergy));
		LooseEnergy (energy - fullEnergy);
	}

//	void OnTriggerEnter (Collision col)
//	{
//		if(col.gameObject.tag == "Energy")
//		{
//            Debug.Log("Energy clollected");
//			GainEnergy ();
//			Destroy(col.gameObject);
//		}
//	}

	void OnTriggerEnter(Collider other) {
		//Destroy(other.gameObject);
		if(other.gameObject.tag == "Energy")
		{
			Debug.Log("Energy clollected");
			GainEnergy ();
			Destroy(other.gameObject);
		}
	}


}
