using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyEnergy : MonoBehaviour {

	public float energy = 1000;
//	private TextMesh text;

	public AudioClip deathSound;
	private AudioSource ac;

	public void LooseEnergy (float damage) {
		energy -= damage;
		//makes enemies trasparent
		Color c =  gameObject.GetComponent<Renderer> ().material.color;
		gameObject.GetComponent<Renderer> ().material.color = new Color(c.r, c.g, c.b,  energy/1000);
//		Debug.Log (c.ToString());
		if (energy <= 0) {
			ac.clip = deathSound;
			ac.Play ();
			HUDManager hm = GameObject.Find ("HUD").GetComponent<HUDManager> ();
			if(hm.available < hm.GetMaxAvailable()){
				hm.available += 1;
			}
			Destroy (gameObject);
		}
	}

	void Start(){
//		text = gameObject.AddComponent<TextMesh> ();
		ac = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource> ();
	}

	void Update(){
//		text.text = energy.ToString ();
	}


}
