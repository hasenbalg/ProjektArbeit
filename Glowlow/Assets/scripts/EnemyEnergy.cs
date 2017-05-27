﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyEnergy : MonoBehaviour {

	public float energy = 1000;
	TextMesh text;


	public void LooseEnergy (float damage) {
		energy -= damage;
		//makes enemies trasparent
		Color c =  gameObject.GetComponent<Renderer> ().material.color;
		gameObject.GetComponent<Renderer> ().material.color = new Color(c.r, c.g, c.b,  energy/1000);
		Debug.Log (c.ToString());
		if (energy == 0) {
			Destroy (gameObject);
		}
	}

	void Start(){
		text = gameObject.AddComponent<TextMesh> ();

	}

	void Update(){
		text.text = energy.ToString ();
	}


}
