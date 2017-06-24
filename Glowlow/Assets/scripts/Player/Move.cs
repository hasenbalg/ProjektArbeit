﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	[Header("Speeds")]
	public float normalSpeed;
	public float rotSpeed;
	public float reducedSpeed;
	private float currentSpeed, currentRotSpeed;
	public float gravity = 20;
	[Space(10)]
//    public float jumpSpeed ;

	[Header("Lamp")]
    public GameObject lamp;
	public float minAngleSpot;
	public float maxAngleSpot;
    private Vector3 moveDirection = Vector3.zero;
    
	private float lastSpeed;

	private Energy nrg;

	void Start () {
		currentSpeed = normalSpeed;
		currentRotSpeed = rotSpeed;
		nrg = GetComponent<Energy> ();
	}

    // Update is called once per frame
    void Update() {

        // Movement
        CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) {
			moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
			moveDirection = transform.TransformDirection (moveDirection);
			moveDirection *= currentSpeed;

		} else {
			moveDirection.y -= gravity * Time.deltaTime;
		}

		controller.Move(moveDirection * Time.deltaTime);


        if (Input.GetKey(KeyCode.E))
        {
            ChangeSpot(+1);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            ChangeSpot(-1);
        }

        //mouse
		transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X")*5, 0) * Time.deltaTime * currentRotSpeed);

		Vector3 rot = transform.Find ("Cam&Light").transform.localEulerAngles;
		rot.x -= Input.GetAxis ("Mouse Y");
		rot.x = (rot.x > 180) ? rot.x - 360 : rot.x;
		rot.x = Mathf.Clamp (rot.x, -20f, 20f);
		transform.Find("Cam&Light").transform.localEulerAngles = new Vector3( rot.x, 0, 0);


        //pan/tilt cam and light
        float rStickX = Input.GetAxis("X360_R_Stick_X");
        float rStickY = Input.GetAxis("X360_R_Stick_Y");


		transform.Rotate(new Vector3(0, rStickX *5, 0) * Time.deltaTime * currentRotSpeed);
		// cam up & down
		if(rStickY != 0){
			transform.Find ("Cam&Light").transform.localEulerAngles = new Vector3( rStickY * 20f ,rot.y, rot.z);

		}


        //spot radius
		ChangeSpot(Input.GetAxis("X360_Triggers") * -1);
        ChangeSpot(Input.GetAxis("X360_Triggers_Linux") * +1);

//  		Debug.Log (currentSpeed);      
    }

    

    //spot
    private void ChangeSpot(float i){
		lamp.GetComponent<Light>().spotAngle += i;
		if(lamp.GetComponent<Light>().spotAngle > maxAngleSpot){
			lamp.GetComponent<Light> ().spotAngle = maxAngleSpot;
		}else if(lamp.GetComponent<Light>().spotAngle < minAngleSpot){
			lamp.GetComponent<Light> ().spotAngle = minAngleSpot;
		}

		nrg.LooseEnergyOverTime(lamp.GetComponent<Light> ().spotAngle);
    }



	public void SetCurrentSpeed(float newSpeed){
		currentSpeed = newSpeed;
	}
	public void SetCurrentSpeed(){
		currentSpeed = normalSpeed;
	}




}
