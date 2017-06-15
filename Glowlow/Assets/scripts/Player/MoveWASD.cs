using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWASD : MonoBehaviour {

	// Use this for initialization
	public float speed;
	public float rotSpeed;
//    public float jumpSpeed ;
    public GameObject test;
    private Rigidbody rb;
    private Vector3 moveDirection = Vector3.zero;
    public float gravity = 20;

    private string [] colors;

	void Start () {
        rb = GetComponent<Rigidbody>();

        colors = new string[] { "red", "blue", "yellow" };
	}

    // Update is called once per frame
    void Update() {

        // Movement
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
//			if (Input.GetKeyDown("space") || Input.GetButtonDown ("X360_A"))
//            {
//                moveDirection.y = jumpSpeed;
//            }
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

//        if (Input.GetKeyDown(KeyCode.LeftControl)) //crouch
//        {
//            transform.GetChild(0).localPosition = new Vector3(0, -0.25f, 0); // GetChild(0) ist die Kamera/das Kamera-Flashlight Konstrukt
//        }
//
//        if (Input.GetKeyUp(KeyCode.LeftControl)) //stand Up
//        {
//            transform.GetChild(0).localPosition = new Vector3(0, 0, 0); // GetChild(0) ist die Kamera/das Kamera-Flashlight Konstrukt
//        }



       /* Vector3 temp = transform.position;
        if (Input.GetKey(KeyCode.W)) {
            MoveForward();
        }
        if (Input.GetKey(KeyCode.S)) {
            MoveBackward();
        }
        if (Input.GetKey(KeyCode.A)) {
            TurnLeft();
        }
        if (Input.GetKey(KeyCode.D)) {
            TurnRight();
        }
       
        //jump
        if (Input.GetKeyDown("space")){
            jump();
        }

        //crouching
        if (Input.GetKeyDown("m")){
            crouch();
        }
*/
        if (Input.GetKey(KeyCode.E))
        {
            ChangeSpot(+1);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            ChangeSpot(-1);
        }

        //mouse
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X")*5, 0) * Time.deltaTime * rotSpeed);

		Vector3 rot = transform.FindChild ("Cam&Light").transform.localEulerAngles;
		rot.x -= Input.GetAxis ("Mouse Y");
		rot.x = (rot.x > 180) ? rot.x - 360 : rot.x;
		rot.x = Mathf.Clamp (rot.x, -20f, 20f);
		transform.FindChild("Cam&Light").transform.localEulerAngles = new Vector3( rot.x, 0, 0);


        //pan/tilt cam and light
        float rStickX = Input.GetAxis("X360_R_Stick_X");
        float rStickY = Input.GetAxis("X360_R_Stick_Y");

//		Vector3 rot = transform.FindChild ("Cam&Light").transform.localEulerAngles;

		transform.Rotate(new Vector3(0, rStickX *5, 0) * Time.deltaTime * rotSpeed);
		// cam up & down
		if(rStickY != 0){
			transform.FindChild ("Cam&Light").transform.localEulerAngles = new Vector3( rStickY * 20f ,rot.y, rot.z);

		}


        //spot radius
		ChangeSpot(Input.GetAxis("X360_Triggers") * -1);
        ChangeSpot(Input.GetAxis("X360_Triggers_Linux") * +1);

  

        
    }

    private void MoveForward(){
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    private void MoveBackward(){
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }

	private void MoveRight(){
		transform.Translate(Vector3.right * Time.deltaTime * speed);
	}

	private void MoveLeft(){
		transform.Translate(Vector3.right * -1 * Time.deltaTime * speed);
	}

    private void TurnLeft() {
        transform.Rotate(Vector3.down * Time.deltaTime * rotSpeed);
    }

    private void TurnRight(){
        transform.Rotate(Vector3.up * Time.deltaTime * rotSpeed);
    }


    //spot
    private void ChangeSpot(float i){
        test.GetComponent<Light>().spotAngle += i;
    }

    private void DecrementSpot(){
        test.GetComponent<Light>().spotAngle--;
    }

    






}
