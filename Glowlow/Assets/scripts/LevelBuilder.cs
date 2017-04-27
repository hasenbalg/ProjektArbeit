using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]

public class LevelBuilder : MonoBehaviour {
	public Material mat;
	public Mesh I, T, P, G;
	public float tileSize = 3;

	/*
https://en.wikipedia.org/wiki/Box-drawing_character
0	1	2	3	4	5	6	7	8	9	A	B	C	D	E	F
B				│	┤					╣	║	╗	╝			┐
C	└	┴	┬	├	─	┼			╚	╔	╩	╦	╠	═	╬	
D										┘	┌					

	*/

	char[,] map2 = {
		{'O','║','O','O','O','O','O','O','O','O'},
		{'O','║','O','O','O','O','O','O','O','O'},
		{'O','║','O','O','O','O','╔','═','═','O'},
		{'O','║','O','O','O','O','║','O','O','O'},
		{'O','║','O','O','O','O','║','O','O','O'},
		{'O','║','O','O','O','O','║','O','O','O'},
		{'O','║','╔','╗','O','╔','╝','O','O','O'},
		{'O','╚','╝','╚','═','╣','O','O','O','O'},
		{'O','O','O','O','O','║','O','O','O','O'},
		{'O','O','O','O','O','║','O','O','O','O'}
	};

	char[,] map = {
		{'O','║','O','O','O','O','O','O','O','O'},
		{'O','║','O','O','O','O','O','O','O','O'},
		{'O','╠','═','═','═','═','╦','═','═','O'},
		{'O','║','O','O','O','O','║','O','O','O'},
		{'O','║','O','O','O','O','║','O','O','O'},
		{'O','║','O','O','O','O','║','O','O','O'},
		{'O','║','╔','╗','O','╔','╝','O','O','O'},
		{'O','╚','╝','╚','═','╣','O','O','O','O'},
		{'O','O','O','O','O','║','O','O','O','O'},
		{'O','O','O','O','O','║','O','O','O','O'}
	};

	// Use this for initialization
	void Awake () {
		BuildLevel ();
	}
	public void BuildLevel(){

		foreach (Transform child in transform) {
			GameObject.Destroy(child.gameObject);
		}

		int z,x;
		string output = "";

		for(x = 0; x < map.GetLength(0); x++){
			output += "\n";
			for(z = 0; z < map.GetLength(1); z++){
				output += map [x,z] + ",";
				if(map[x, z] != 'O'){
					GameObject go = new GameObject();
					go.name = "Modul";
					go.transform.parent = gameObject.transform;
					go.AddComponent<MeshFilter> ();
					go.AddComponent<MeshRenderer> ().material = mat;
					go.layer = LayerMask.NameToLayer("ExplorerViewLayer");
					go.transform.position = new Vector3 (z * tileSize, 0, -x * tileSize);
					switch(map[x, z]){
					case '╣':
						go.GetComponent<MeshFilter> ().sharedMesh = T;
						go.transform.rotation = Quaternion.Euler (-90,0,0);
						break;
					case '║':
						go.GetComponent<MeshFilter> ().sharedMesh = I;
						//go.transform.rotation = Quaternion.Euler (0, 0, 0);
						go.transform.rotation = Quaternion.Euler (0,0,-202.5f);
						go.transform.localScale = new Vector3 (1,1,2);
						break;
					case '╗':
						go.GetComponent<MeshFilter> ().sharedMesh  = G;
						go.transform.rotation = Quaternion.Euler (-90,270,0);
						break;
					case '╝':
						go.GetComponent<MeshFilter> ().sharedMesh = G;
						go.transform.rotation = Quaternion.Euler (-90,0,0);
						break;
					case '╚':
						go.GetComponent<MeshFilter> ().sharedMesh = G;
						go.transform.rotation = Quaternion.Euler (-90,90,0);
						break;
					case '╔':
						go.GetComponent<MeshFilter> ().sharedMesh = G;
						go.transform.rotation = Quaternion.Euler (-90,180,0);
						break;
					case '╩':
						go.GetComponent<MeshFilter> ().sharedMesh = T;
						go.transform.rotation = Quaternion.Euler (-90,90,0);
						break;
					case '╦':
						go.GetComponent<MeshFilter> ().sharedMesh = T;
						go.transform.rotation = Quaternion.Euler (-90,-270,0);
						break;
					case '╠':
						go.GetComponent<MeshFilter> ().sharedMesh = T;
						go.transform.rotation = Quaternion.Euler (-90,-180,0);
						break;
					case '═':
						go.GetComponent<MeshFilter> ().sharedMesh = I;
						go.transform.rotation = Quaternion.Euler (0,-90,-202.5f);
						go.transform.localScale = new Vector3 (1,1,2);
						break;
					case '╬':
						go.GetComponent<MeshFilter> ().sharedMesh = P;
						break;
					default:
						go.GetComponent<MeshFilter> ().sharedMesh = null;
						break;
					}
					go.AddComponent<MeshCollider> ().sharedMesh = (Mesh)go.GetComponent<MeshFilter>().sharedMesh;
					Debug.Log (go.name);
				}
			}
		}

		Debug.Log (output);
	}



}
