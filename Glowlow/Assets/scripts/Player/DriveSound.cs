using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveSound : MonoBehaviour {

	// Use this for initialization
	private AudioSource ac;
	public AudioClip drive;

	private CharacterController cc;
	void Start () {
		ac = GetComponent<AudioSource> ();
		cc = GetComponent<CharacterController> ();

	}
	
	// Update is called once per frame
	void Update () {
		if(Mathf.Abs(cc.velocity.x) > .01f && !ac.isPlaying){
			ac.clip = drive;
			ac.Play ();
		}

	}
}
