using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWASD : MonoBehaviour {

	// Use this for initialization
	public float speed;
	public float rotSpeed;
    public float jumpSpeed;
    public GameObject test;
    private Rigidbody rb;

    private string [] colors;
    private int currentColorIndex;

	void Start () {
        rb = GetComponent<Rigidbody>();

        colors = new string[] { "red", "blue", "yellow" };
	}

    // Update is called once per frame
    void Update() {
        Vector3 temp = transform.position;
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

        if (Input.GetKey(KeyCode.E))
        {
            ChangeSpot(+1);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            ChangeSpot(-1);
        }

        //change color
        if (Input.GetKeyDown("2")){
            ColorIndexUp();
        }
        if (Input.GetKeyDown("1")){
            ColorIndexDown();
        }

        

        //////////////////////////////////////////////////////
        //controller https://www.youtube.com/watch?v=s5x-TqLqGWA

        //navigate player
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * vAxis * Time.deltaTime * speed);
        transform.Rotate(Vector3.down * -hAxis * Time.deltaTime * rotSpeed);

        //pan/tilt cam and light
        float rStickX = Input.GetAxis("X360_R_Stick_X");
        float rStickY = Input.GetAxis("X360_R_Stick_Y");
        // IMPLEMET ME!!!!!!!!!!!

        //spot radius
        ChangeSpot(Input.GetAxis("X360_Triggers") * -1);

        //jump
        if (Input.GetButtonDown("X360_A")) { jump();}

        //change color
        if (Input.GetButtonDown("X360_R_Bumper")) { ColorIndexUp();}
        if (Input.GetButtonDown("X360_L_Bumper")) { ColorIndexDown();}
    }

    private void MoveForward(){
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    private void MoveBackward(){
        transform.Translate(Vector3.back * Time.deltaTime * speed);
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

    private void ColorIndexUp(){
        currentColorIndex++;
        if (currentColorIndex > colors.Length - 1) { currentColorIndex = 0; }
        print(currentColorIndex);
    }

    private void ColorIndexDown(){
        currentColorIndex--;
        if (currentColorIndex < 0) { currentColorIndex = colors.Length - 1; }
        print(currentColorIndex);
    }






}
