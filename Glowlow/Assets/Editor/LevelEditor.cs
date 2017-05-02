using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(LevelBuilder))]
public class LevelEditor : Editor {
	//https://www.youtube.com/watch?v=fja14SIwRQQ
	public override void OnInspectorGUI(){
		base.OnInspectorGUI ();
		if(GUILayout.Button("REgenerate The MAP!!!!!!!")){
			LevelBuilder buildMap  = (LevelBuilder) target;
			//buildMap.BuildLevel ();
		}
	}

}
