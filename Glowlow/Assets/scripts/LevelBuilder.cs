using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
//[ExecuteInEditMode]

public class LevelBuilder : MonoBehaviour {
	public Material mat, mat2;
	public Mesh I, T, P, G;
	public float tileSize;

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

	char[,] map1 = {
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
	char[,] map = {
		{'╔','╗','╔','═','═','╗','O','╔','═','═','═','═','═','╗'},
		{'║','╚','╝','O','O','║','O','║','O','O','O','O','O','║'},
		{'╚','╗','O','╔','╗','╚','═','╬','╦','═','═','╦','═','╣'},
		{'O','╠','═','╝','╚','╗','O','║','╠','═','═','╩','╗','║'},
		{'═','╝','O','╔','═','╝','O','║','╚','═','═','╗','╚','╣'},
		{'═','═','═','╬','═','═','╦','╣','O','╔','╗','╠','═','╬'},
		{'O','O','O','╚','═','═','╩','╩','═','╩','╝','╚','═','╝'}
	};

	char[,] map4 = {
		{'╔','╗','╔','═','═','╗','O','╔','═','═','═','═','═','╗'},
		{'║','╚','╝','O','O','╦','O','╩','O','O','O','O','O','║'}
	
	};

	// Use this for initialization
	void Awake () {
		BuildLevel ();
	}
	public void BuildLevel(){
		
//		while(transform.childCount != 0){
//			Debug.Log (transform.childCount + "huhu");
//			DestroyImmediate(transform.GetChild(0).gameObject);
//		}
		DeleteChildren(transform.gameObject);




		int z,x;
		string output = "";

		for(x = 0; x < map.GetLength(0); x++){
			output += "\n";
			for(z = 0; z < map.GetLength(1); z++){
				output += map [x,z] + ",";
				if(map[x, z] != 'O'){
					GameObject go = new GameObject();
					go.name = "Modul"+ map[x, z];
					go.tag = "Modul";
					go.transform.parent = gameObject.transform;
					go.AddComponent<MeshFilter> ();

					go.AddComponent<MeshRenderer> ().material = mat;

//					if ((x % 2) == (z % 2)) {
//						go.GetComponent<MeshRenderer> ().material = mat2;
//					}
					go.GetComponent<MeshRenderer> ().material.color = Color.grey;

					go.layer = LayerMask.NameToLayer("ExplorerViewLayer");
					go.transform.position = new Vector3 (z * tileSize, 0, -x * tileSize);
					switch(map[x, z]){
					case '╣':
						go.GetComponent<MeshFilter> ().sharedMesh = T;
						go.transform.rotation = Quaternion.Euler (-0,0,0);
						break;
					case '║':
						go.GetComponent<MeshFilter> ().sharedMesh = I;
						//go.transform.rotation = Quaternion.Euler (0, 0, 0);
						go.transform.rotation = Quaternion.Euler (0,0,0);
						go.transform.localScale = new Vector3 (1,1,1);
						break;
					case '╗':
						go.GetComponent<MeshFilter> ().sharedMesh  = G;
						go.transform.rotation = Quaternion.Euler (-0,270,0);
						break;
					case '╝':
						go.GetComponent<MeshFilter> ().sharedMesh = G;
						go.transform.rotation = Quaternion.Euler (0,0,0);
						break;
					case '╚':
						go.GetComponent<MeshFilter> ().sharedMesh = G;
						go.transform.rotation = Quaternion.Euler (-180,-90,-180);
						break;
					case '╔':
						go.GetComponent<MeshFilter> ().sharedMesh = G;
						go.transform.rotation = Quaternion.Euler (0,180,0);
						break;
					case '╩':
						go.GetComponent<MeshFilter> ().sharedMesh = T;
						go.transform.rotation = Quaternion.Euler (0,90,0);
						break;
					case '╦':
						go.GetComponent<MeshFilter> ().sharedMesh = T;
						go.transform.rotation = Quaternion.Euler (-0,-90,0);
						break;
					case '╠':
						go.GetComponent<MeshFilter> ().sharedMesh = T;
						go.transform.rotation = Quaternion.Euler (-0,-180,0);
						break;
					case '═':
						go.GetComponent<MeshFilter> ().sharedMesh = I;
						go.transform.rotation = Quaternion.Euler (0,-90,0);
						go.transform.localScale = new Vector3 (1,1,1);
						break;
					case '╬':
						go.GetComponent<MeshFilter> ().sharedMesh = P;
						go.transform.rotation = Quaternion.Euler (-90,0,0);

						break;
					default:
						go.GetComponent<MeshFilter> ().sharedMesh = null;
						break;
					}
					go.AddComponent<MeshCollider> ().sharedMesh = (Mesh)go.GetComponent<MeshFilter>().sharedMesh;
					//Debug.Log (go.name);
				}
			}
		}

		//Debug.Log (output);
	}

	private void DeleteChildren (GameObject badParent) {
		List <Transform> children = badParent.transform.Cast <Transform> ().ToList ();
		foreach (Transform child in children) {
			GameObject.DestroyImmediate (child.gameObject);
		}
	}


}
