using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWASD : MonoBehaviour {

	// Use this for initialization
	public float speed;
	public float rotSpeed;
    public float jumpSpeed ;
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
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftControl)) //crouch
        {
            transform.GetChild(0).localPosition = new Vector3(0, -0.25f, 0); // GetChild(0) ist die Kamera/das Kamera-Flashlight Konstrukt
        }

        if (Input.GetKeyUp(KeyCode.LeftControl)) //stand Up
        {
            transform.GetChild(0).localPosition = new Vector3(0, 0, 0); // GetChild(0) ist die Kamera/das Kamera-Flashlight Konstrukt
        }



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



        //////////////////////////////////////////////////////
        //controller https://www.youtube.com/watch?v=s5x-TqLqGWA

        //navigate player
        float vAxis = Input.GetAxis("Vertical");
		transform.Translate(Vector3.forward * vAxis * Time.deltaTime * speed);
		float hAxis = Input.GetAxis("Horizontal");
		transform.Translate(Vector3.right * hAxis * Time.deltaTime * speed);
       // transform.Rotate(Vector3.down * -hAxis * Time.deltaTime * rotSpeed);

        //pan/tilt cam and light
        float rStickX = Input.GetAxis("X360_R_Stick_X");
        float rStickY = Input.GetAxis("X360_R_Stick_Y");
		transform.Rotate(new Vector3(0, rStickX *5, 0) * Time.deltaTime * rotSpeed);

        //spot radius
		ChangeSpot(Input.GetAxis("X360_Triggers") * -1);
        ChangeSpot(Input.GetAxis("X360_Triggers_Linux") * +1);

        //jump
        if (Input.GetButtonDown("X360_A")) { jump();}


        
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

    private void jump() {
        //http://answers.unity3d.com/answers/427520/view.html
        transform.Translate(Vector3.up * jumpSpeed * Time.deltaTime, Space.World);
    }

    private void crouch()
    {
        //implemet me!
    }

    //spot
    private void ChangeSpot(float i){
        test.GetComponent<Light>().spotAngle += i;
    }

    private void DecrementSpot(){
        test.GetComponent<Light>().spotAngle--;
    }

    






}
