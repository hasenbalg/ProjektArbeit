using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceDocks2 : MonoBehaviour {

	public GameObject dock2;
	private GameObject[] docks2Placehoders;

	[Range(1, 10)]
	public int maxNumDocks = 5;

	private bool placeHolderNumReached = false;


	void Start(){
		docks2Placehoders = GameObject.FindGameObjectsWithTag("Dock2Placeholder");
		foreach(GameObject d2ph in docks2Placehoders){
			d2ph.GetComponent<MeshRenderer> ().enabled = false;
		}
	}

	void Update () {
		docks2Placehoders = GameObject.FindGameObjectsWithTag("Dock2Placeholder");

		if (docks2Placehoders.Length > maxNumDocks) {
			Destroy (docks2Placehoders [Random.Range (0, docks2Placehoders.Length - 1)]);
		} else {
			placeHolderNumReached = true;
		}

//		if (!placeHolderNumReached) {
//			GetComponent<Pause> ().isPause = true;
//		} else {
//			GetComponent<Pause> ().isPause = false;
//		}


		if(placeHolderNumReached){
			foreach(GameObject d2ph in docks2Placehoders){
				Instantiate (dock2, d2ph.transform.position, d2ph.transform.rotation );
				Destroy (d2ph);
			}
		}

	}
	
}
