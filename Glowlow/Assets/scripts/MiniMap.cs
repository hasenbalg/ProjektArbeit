using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour {

	public Material material;
	public float scaleFactor = .007f;

	void BuildMap(Transform modul){
		Debug.Log (modul.name);
		GameObject map_modul = new GameObject ();
		map_modul.name = modul.name;
		map_modul.layer = LayerMask.NameToLayer("ExplorerViewLayer"); //http://answers.unity3d.com/answers/18473/view.html
		MeshFilter mf = map_modul.AddComponent<MeshFilter> ();
		MeshRenderer mr = map_modul.AddComponent<MeshRenderer> ();
//		mf.mesh = modul.Find("default").GetComponent<MeshFilter> ().mesh;
		mf.mesh = modul.GetComponent<MeshFilter> ().mesh;
		map_modul.transform.position = modul.transform.position;
		mr.material = material;
		mr.enabled = false;
		map_modul.transform.Rotate(modul.eulerAngles);
		map_modul.transform.parent = gameObject.transform;
	}

	// Use this for initialization
	void Start () {
		GameObject map = GameObject.Find ("GameManager");
		foreach(Transform modul in map.transform){
			if(modul.name.Contains("group")){
				foreach (Transform g_modul in modul.transform) {
					BuildMap (g_modul);
				}
			}else{
				BuildMap (modul);
			}

		}
		transform.localScale = new Vector3 (scaleFactor,scaleFactor,scaleFactor);
	}

	public void ToggleMap(){
		if (transform.GetChild (0).GetComponent<MeshRenderer> ().enabled) {
			foreach (Transform child in transform) {
				child.GetComponent<MeshRenderer> ().enabled = false;
			}
		} else {
			foreach (Transform child in transform) {
				child.GetComponent<MeshRenderer> ().enabled = true;
			}
		}
		
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
