using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

//[ExecuteInEditMode]

public class LevelBuilder2 : MonoBehaviour
{

	public GameObject i, g, p, t;
	public float tileSize;

	string[] map = {
		"╔╗╔══╗O╔═════╗",
		"║╚╝OO║O║OOOOO║",
		"╚╗O╔╗╚═╬╦══╦═╣",
		"O╠═╝╚╗O║╠══╩╗║",
		"═╝O╔═╝O║╚══╗╚╣",
		"═══╬══╦╣O╔╗╠═╬",
		"OOO╚══╩╩═╩╝╚═╝"
	};

	void Awake ()
	{
		BuildLevel ();
	}

	public void BuildLevel ()
	{
		DeleteChildren ();


		int z = 0, x = 0;
		foreach(string line in map) {
			
			foreach (char c in line) {
				switch (c) {
				case '╣':
					CreateModul (t, Quaternion.Euler (0, 0, 0), new Vector3 (tileSize * x, 0, tileSize * -z));
					break;
				case '║':
					CreateModul (i, Quaternion.Euler (0, 0, 0), new Vector3 (tileSize * x, 0, tileSize * -z));
					break;
				case '╗':
					CreateModul (g, Quaternion.Euler (0, 270, 0), new Vector3 (tileSize * x, 0, tileSize * -z));
					break;
				case '╝':
					CreateModul (g, Quaternion.Euler (0, 0, 0), new Vector3 (tileSize * x, 0, tileSize * -z));
					break;
				case '╚':
					CreateModul (g, Quaternion.Euler (-180, -90, -180), new Vector3 (tileSize * x, 0, tileSize * -z));
					break;
				case '╔':
					CreateModul (g, Quaternion.Euler (0, 180, 0), new Vector3 (tileSize * x, 0, tileSize * -z));
					break;
				case '╩':
					CreateModul (t, Quaternion.Euler (0, 90, 0), new Vector3 (tileSize * x, 0, tileSize * -z));
					break;
				case '╦':
					CreateModul (t, Quaternion.Euler (0, -90, 0), new Vector3 (tileSize * x, 0, tileSize * -z));
					break;
				case '╠':
					CreateModul (t, Quaternion.Euler (0, -180, 0), new Vector3 (tileSize * x, 0, tileSize * -z));
					break;
				case '═':
					CreateModul (i, Quaternion.Euler (0, -90, 0), new Vector3 (tileSize * x, 0, tileSize * -z));
					break;
				case '╬':
					CreateModul (p, Quaternion.Euler (0, 90, 0), new Vector3 (tileSize * x, 0, tileSize * -z));

					break;
				default:
					break;
				}

				x++;
			}
			x = 0;
			z++;
		}


		//Debug.Log (output);
	}

	private void CreateModul(GameObject go, Quaternion rot, Vector3 pos){
		GameObject huhu = Instantiate (go, pos, rot);
		huhu.transform.parent= gameObject.transform;
	}

	private void DeleteChildren ()
	{
		List <Transform> children = transform.Cast <Transform> ().ToList ();
		Debug.Log (children.Count);
		foreach (Transform child in children) {
			Debug.Log(transform.childCount);
			GameObject.DestroyImmediate (child.gameObject);
		}
		Debug.Log (transform.childCount);
	}


}
