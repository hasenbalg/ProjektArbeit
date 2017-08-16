using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : MonoBehaviour {


	public GameObject enemy, battery; 
	public float monitoringDistance;
	// Use this for initialization

	Dictionary<int, GameObject> monitoredEnemies = new Dictionary<int, GameObject>();
	Queue<int> markers2Remove = new Queue<int>();

	GameObject player;
	void Start () {
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		foreach(GameObject e in GameObject.FindGameObjectsWithTag("Enemy")){
			
			if(Vector3.Distance(e.transform.position, player.transform.position) <= monitoringDistance && !monitoredEnemies.ContainsKey(e.GetInstanceID())){
				Debug.Log (monitoredEnemies.Count);
				GameObject enemyMarker = Instantiate (enemy, enemy.transform.position, Quaternion.identity);
				enemyMarker.transform.SetParent(transform, false);
				monitoredEnemies.Add (e.GetInstanceID(), enemyMarker);
			}
		}

		foreach (GameObject e in GameObject.FindGameObjectsWithTag("Enemy")) {
			if(Vector3.Distance(e.transform.position, player.transform.position) > monitoringDistance && monitoredEnemies.ContainsKey(e.GetInstanceID())){
				//monitoredEnemies.Remove (e.GetInstanceID);
				markers2Remove.Enqueue(e.GetInstanceID());
			}
		}

		while(markers2Remove.Count > 0){
			int id = markers2Remove.Dequeue ();
			Destroy (monitoredEnemies[id].gameObject);
			monitoredEnemies.Remove (id);
		}


		foreach (GameObject e in GameObject.FindGameObjectsWithTag("Enemy")) {
			if(monitoredEnemies.ContainsKey(e.GetInstanceID())){
				Vector3 markerPos = Vector3.Scale(
					e.transform.position.normalized,
					GameObject.Find("Monitor").transform.localScale
				);
					
				monitoredEnemies [e.GetInstanceID()].transform.localPosition = markerPos / monitoringDistance;

				transform.localRotation = player.transform.rotation;


			}
		}
	}
}
