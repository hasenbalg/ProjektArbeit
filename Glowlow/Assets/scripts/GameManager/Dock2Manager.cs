using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Dock2Manager : MonoBehaviour {


	private GameObject[] docks;
	private float totalTimeLeft = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		docks = GameObject.FindGameObjectsWithTag("Dock2");
//		Debug.Log (docks.Length + "Docks length");

		int sum = 0;
		foreach(GameObject go in docks){
			if (go.GetComponent<Dock2Energy> ().isFilled) {
				sum++;
			}

		}
		if (sum == docks.Length) {
			Debug.Log ("Game OVER man");
			foreach(GameObject go in docks){
				Destroy (go);

			}
//			SceneManager.LoadScene ("start");
			GameEnd.GameWin ();
		}
	}
}
