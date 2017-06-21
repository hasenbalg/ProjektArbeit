using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour {

	public Light lamp;
	public float punchImpact;
	[Range(.01f, 1f)]
	public float lampRange;
	ViewSwitch vs;

	void Start()
	{	
		vs = (ViewSwitch) GetComponent(typeof(ViewSwitch));

	}

	void Update()
	{
		float lampOpenAngle = lamp.spotAngle/2;
		float brightness = lamp.intensity;
		//http://answers.unity3d.com/answers/1097025/view.html
		Vector3  d = transform.forward * brightness; //who far

		//right ray
		Quaternion q = Quaternion.AngleAxis(lampOpenAngle, Vector3.up * lampRange);
		Debug.DrawRay (transform.position,q*d,Color.green);

		//left ray
		Quaternion p = Quaternion.AngleAxis(-lampOpenAngle, Vector3.up * lampRange);
		Debug.DrawRay (transform.position,p*d,Color.green);


		if(vs.GetStatus() == Views.FRAG){
			foreach(GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy")){
				hit_enemy (enemy, lampOpenAngle);
			}
		}


	}

	private void hit_enemy(GameObject enemy, float lampOpenAngle){
		//if enemy is in distance and angle towards the enemy is correct
		if(Vector3.Distance (transform.position, enemy.transform.position) < lamp.range * lampRange
			&& Mathf.Abs(Vector3.Angle(enemy.transform.position - transform.position, transform.forward)) < lampOpenAngle){
			//Debug.Log ("HITTTTTTTT");
			EnemyEnergy other = (EnemyEnergy) enemy.GetComponent(typeof(EnemyEnergy));
			other.LooseEnergy(punchImpact);

		}
	}
}