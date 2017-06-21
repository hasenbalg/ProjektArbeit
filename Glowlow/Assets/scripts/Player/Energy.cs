using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Energy : MonoBehaviour {


	public Light playerLight;
	private float fullEnergy;
	public float energy = 1000f;
	private float fullIntensity;
	public float lowEnergyWarnigPercent = .3f;
	public AudioClip collectBattery;
	public AudioClip lowEnergy;
	private AudioSource ac;

	public Texture flickerTexture;

	private double nextFlicker;
	private bool isFlickering = false;

    void Start(){
		ac = GetComponent<AudioSource> ();

		fullEnergy = energy;
		fullIntensity = playerLight.intensity;


		// add flicker on low energy

	}


	public void LooseEnergy (float damage) {
		energy -= damage;
		playerLight.intensity = fullIntensity * (energy / fullEnergy);
		if (energy <= 0) {
//			Destroy (gameObject);
			GameEnd.GameOver ();
		}
	}

	public void GainEnergy(){
//		fill up to 100%
		Debug.Log("Energy to gain: " + (energy - fullEnergy));
		LooseEnergy (energy - fullEnergy);
	}


	void OnTriggerEnter(Collider other) {
		//Destroy(other.gameObject);
		if(other.gameObject.tag == "Energy")
		{
//			Debug.Log("Energy clollected");
			GainEnergy ();
			Destroy(other.gameObject);
			ac.clip = collectBattery;
			ac.Play ();
		}
	}

	void Update(){
		if(energy / fullEnergy < lowEnergyWarnigPercent){
			LowEnergyWarning ();
		}
	}

	public void LowEnergyWarning(){
		// flicker
		double currentTime = Time.realtimeSinceStartup;
		if (currentTime > nextFlicker) {
			nextFlicker = Random.Range(1, 5) + currentTime;
			isFlickering = true;

			ac.clip = lowEnergy;
			ac.Play ();
		} else {
			isFlickering = false;
		}


	}

	void OnGUI() {
		if(isFlickering){
			GUI.DrawTexture(new Rect(0,0,Screen.width, Screen.height), flickerTexture);
		}
	}
}
