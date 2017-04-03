using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSpawner : MonoBehaviour {

	public float timeInterval;
	public float lifeTime;
	public Object light;
	// Use this for initialization
	void Start () {
		//StartCoroutine(SpawnLightsContinously());
	}

	IEnumerator SpawnLightsContinously(){
		while(true)
		{
			//DoSomething();
			Object newLight = Instantiate(light, transform.position, transform.rotation);
			Destroy (newLight, lifeTime);
			yield return new WaitForSeconds(timeInterval);
		}
	}
}
