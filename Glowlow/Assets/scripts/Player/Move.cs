using System.Collections;
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


	void Start () {
		currentSpeed = normalSpeed;
		currentRotSpeed = rotSpeed;
	}

    // Update is called once per frame
    void Update() {

        // Movement
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= currentSpeed;

        }
        moveDirection.y -= gravity * Time.deltaTime;
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

		Vector3 rot = transform.FindChild ("Cam&Light").transform.localEulerAngles;
		rot.x -= Input.GetAxis ("Mouse Y");
		rot.x = (rot.x > 180) ? rot.x - 360 : rot.x;
		rot.x = Mathf.Clamp (rot.x, -20f, 20f);
		transform.FindChild("Cam&Light").transform.localEulerAngles = new Vector3( rot.x, 0, 0);


        //pan/tilt cam and light
        float rStickX = Input.GetAxis("X360_R_Stick_X");
        float rStickY = Input.GetAxis("X360_R_Stick_Y");

//		Vector3 rot = transform.FindChild ("Cam&Light").transform.localEulerAngles;

		transform.Rotate(new Vector3(0, rStickX *5, 0) * Time.deltaTime * currentRotSpeed);
		// cam up & down
		if(rStickY != 0){
			transform.FindChild ("Cam&Light").transform.localEulerAngles = new Vector3( rStickY * 20f ,rot.y, rot.z);

		}


        //spot radius
		ChangeSpot(Input.GetAxis("X360_Triggers") * -1);
        ChangeSpot(Input.GetAxis("X360_Triggers_Linux") * +1);

  

        
    }

    private void MoveForward(){
        transform.Translate(Vector3.forward * Time.deltaTime * currentSpeed);
    }

    private void MoveBackward(){
        transform.Translate(Vector3.back * Time.deltaTime * currentSpeed);
    }

	private void MoveRight(){
		transform.Translate(Vector3.right * Time.deltaTime * currentSpeed);
	}

	private void MoveLeft(){
		transform.Translate(Vector3.right * -1 * Time.deltaTime * currentSpeed);
	}

    private void TurnLeft() {
		transform.Rotate(Vector3.down * Time.deltaTime * currentRotSpeed);
    }

    private void TurnRight(){
		transform.Rotate(Vector3.up * Time.deltaTime * currentRotSpeed);
    }


    //spot
    private void ChangeSpot(float i){
		lamp.GetComponent<Light>().spotAngle += i;
		if(lamp.GetComponent<Light>().spotAngle > maxAngleSpot){
			lamp.GetComponent<Light> ().spotAngle = maxAngleSpot;
		}else if(lamp.GetComponent<Light>().spotAngle < minAngleSpot){
			lamp.GetComponent<Light> ().spotAngle = minAngleSpot;
		}
    }


    

	public void ToggleFreeze(bool toggle){
		if (toggle) {
			currentSpeed = 0;
		} else {
			currentSpeed = normalSpeed;
		}

	}

	public void ToggleSlower(){
		if(currentSpeed > reducedSpeed){
			currentSpeed = reducedSpeed;
		}else if(currentSpeed == reducedSpeed){
			currentSpeed = normalSpeed;
		}
	}

	public void ToggleFaster(float boosterSpeed){
		if(currentSpeed == normalSpeed){
			currentSpeed = boosterSpeed;
		}else if(currentSpeed > normalSpeed){
			currentSpeed = normalSpeed;
		}
	}




}
