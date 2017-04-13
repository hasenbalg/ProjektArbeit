using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillzzzBooster : MonoBehaviour {

    public float speedBoost = 5.0f;
    private float defaultSpeed;
    private MoveWASD moveWASD;
    private bool controller_X_pressed = false, controller_Y_pressed = false;
    private bool showMap = false;

    // Use this for initialization
    void Start () {
        moveWASD = gameObject.GetComponent<MoveWASD>();
        defaultSpeed = moveWASD.speed;
    }
	
	// Update is called once per frame
	void Update () {
        //SPEEDBOOST
        if (Input.GetKey(KeyCode.LeftShift)) { 
            moveWASD.speed = defaultSpeed + speedBoost;
        }else {
            moveWASD.speed = defaultSpeed;
        }

        //beschissenes controller workaround weil der verhurte xknopf von dem verkackten controller nich ordentlich ausloest scheiss microsoft
        if (Input.GetButtonDown("X360_X")) {
            controller_X_pressed = true;
        }

        if (Input.GetButtonUp("X360_X"))
        {
            controller_X_pressed = false;
        }

        if (controller_X_pressed) {
            moveWASD.speed = defaultSpeed + speedBoost;
        }

        //MAP
        if (Input.GetButtonDown("X360_Y"))
        {
            controller_Y_pressed = true;
        }

        if (Input.GetButtonUp("X360_Y"))
        {
            controller_Y_pressed = false;
        }

        if (controller_Y_pressed)
        {
            showMap = true;
        }
        else
        {
            showMap = false;

            //TAB KEY
            if (Input.GetKey(KeyCode.Tab))
            {
                showMap = true;
            }
            else
            {
                showMap = false;
            }
        }
    }

    void OnGUI()
    {
        if (showMap)
        {
            //https://docs.unity3d.com/ScriptReference/GUI.Box.html
            GUIContent content = new GUIContent("MAP!!!!!!!!!!!!!!!");
            GUI.Box(new Rect(0, 0, Screen.width, Screen.height), content);
        }

    } 
}
