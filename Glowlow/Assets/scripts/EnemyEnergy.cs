using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyEnergy : MonoBehaviour {

	private float energy = 1000;

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
}
