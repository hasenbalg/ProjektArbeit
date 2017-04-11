using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFight : MonoBehaviour {

	public Light lamp;
	//public float scaleSpeed, rotSpeed;

	void Start()
	{	
		

	}

	void Update()
	{
		float lampOpenAngle = lamp.spotAngle/2;
		float brightness = lamp.intensity;
		//http://answers.unity3d.com/answers/1097025/view.html
		Vector3  d = transform.forward * brightness; //who far

		//right ray
		Quaternion q = Quaternion.AngleAxis(lampOpenAngle, Vector3.up);
		Debug.DrawRay (transform.position,q*d,Color.green);

		//left ray
		Quaternion p = Quaternion.AngleAxis(-lampOpenAngle, Vector3.up);
		Debug.DrawRay (transform.position,p*d,Color.green);

		foreach(GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy")){
			hit_enemy (enemy, lampOpenAngle);
		}

	}

	private void hit_enemy(GameObject enemy, float lampOpenAngle){
		//if enemy is in distance and angle towards the enemy is correct

//		print("Distance " + Vector3.Distance ( enemy.transform.position,transform.position));
//		print("angle " + Mathf.Abs(Vector3.Angle(enemy.transform.position - transform.position, transform.forward)));
	
		if(Vector3.Distance (transform.position, enemy.transform.position) < lamp.range
			&& Mathf.Abs(Vector3.Angle(enemy.transform.position - transform.position, transform.forward)) < lampOpenAngle){
			//enemy.damage ();
			Debug.Log ("HITTTTTTTT");

		}
	}
}