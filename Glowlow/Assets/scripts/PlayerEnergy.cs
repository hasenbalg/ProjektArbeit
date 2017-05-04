using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnergy : MonoBehaviour {


	public Light playerLight;
	private float energy = 1000;
	private float fullIntensity;

	void Start(){
		fullIntensity = playerLight.intensity;
	}


	public void LooseEnergy (float damage) {
		energy -= damage;
		playerLight.intensity = fullIntensity * (energy / 1000);
		if (energy == 0) {
			Destroy (gameObject);
		}
	}
}
