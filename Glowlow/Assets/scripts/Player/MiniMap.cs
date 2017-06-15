using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour {

	public Material material;
	public float scaleFactor = .007f;
	public GameObject mapPlayer;
	private GameObject mapPlayer_;

	void BuildMap(Transform modul){
//		Debug.Log (modul.name);
		GameObject map_modul = new GameObject ();
		map_modul.name = modul.name;
		map_modul.tag = "MapModul";
		map_modul.layer = LayerMask.NameToLayer("ExplorerViewLayer"); //http://answers.unity3d.com/answers/18473/view.html
		MeshFilter mf = map_modul.AddComponent<MeshFilter> ();
		MeshRenderer mr = map_modul.AddComponent<MeshRenderer> ();
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
		mapPlayer_ = Instantiate (mapPlayer);
		mapPlayer_.tag = "MapPlayer";
		mapPlayer_.GetComponent<MeshRenderer> ().enabled = false;
		mapPlayer_.transform.parent = gameObject.transform;
		transform.localScale = new Vector3 (scaleFactor,scaleFactor,scaleFactor);

	}

	public void ToggleMap(){
		if (transform.GetChild (0).GetComponent<MeshRenderer> ().enabled) {
			foreach (Transform child in transform) {
				child.GetComponent<MeshRenderer> ().enabled = false;
			}
			mapPlayer_.GetComponent<MeshRenderer> ().enabled = false;
		} else {
			foreach (Transform child in transform) {
				child.GetComponent<MeshRenderer> ().enabled = true;
			}
			mapPlayer_.GetComponent<MeshRenderer> ().enabled = true;
		}
		
	}

	
	// Update is called once per frame
	void Update () {
		Vector3 position = GameObject.Find ("Player").transform.position;
//		mapPlayer_.transform.localPosition = position* mapPlayer_.transform.localScale;
		mapPlayer_.transform.localPosition = Vector3.Scale (position, mapPlayer_.transform.localScale);
	}
}
