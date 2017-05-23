using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnergy : MonoBehaviour {


	public Light playerLight;
	public float fullEnergy = 1000f;
	private float energy;
	private float fullIntensity;
    private GodMode godmode;

	void Start(){
        godmode = GameObject.Find("CanvasGodMode").GetComponent<GodMode>();
		energy = fullEnergy;
		fullIntensity = playerLight.intensity;
	}

    private void Update()
    {
        godmode.UpdateTextFieldPlayerEnergy(energy);
    }

    public void LooseEnergy (float damage) {
        energy -= damage;
		playerLight.intensity = fullIntensity * (energy / fullEnergy);
		if (energy <= 0 && !godmode.IsDeathLessMode()) {
			Destroy (gameObject);
		}
	}

	public void GainEnergy(){
//		fill up to 100%
		Debug.Log("Energy to gain: " + (energy - fullEnergy));
		LooseEnergy (energy - fullEnergy);
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "Energy")
		{
			GainEnergy ();
			Destroy(col.gameObject);
		}
	}
}
