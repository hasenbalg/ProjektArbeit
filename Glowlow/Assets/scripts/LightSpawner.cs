using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSpawner : MonoBehaviour {

	public float timeInterval;
	public float lifeTime;
	public Object light;
	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnLightsContinously());
	}

	IEnumerator SpawnLightsContinously(){
		while(true)
		{
			//DoSomething();
			Object newLight = Instantiate(light, spawnInFronOfPlayer(), transform.rotation);
			Destroy (newLight, lifeTime);
			yield return new WaitForSeconds(timeInterval);
		}
	}

	private Vector3 spawnInFronOfPlayer(){
		Vector3 playerPos = transform.position;
		Vector3 playerDirection = transform.forward;
		Quaternion playerRotation = transform.rotation;
		float spawnDistance = 10;

		Vector3 spawnPos = playerPos + playerDirection*spawnDistance;

		return spawnPos;
	}
}
