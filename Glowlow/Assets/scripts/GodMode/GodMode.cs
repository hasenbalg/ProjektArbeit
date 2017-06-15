using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GodMode : MonoBehaviour {


    private bool isDeathLess = false;
    private bool isFullLight = true;
    private bool isGodModeActive = false;

    private Text textIsDeathless;
    private Text textFullLight;
    private Text textPlayerEnergy;
    private Text textEnemiesOnField;

    void Start()
    {
        textIsDeathless = GameObject.Find("GodModeTextIsDeathless").GetComponentsInChildren<Text>()[1];
        textFullLight = GameObject.Find("GodModeTextIsFullLight").GetComponentsInChildren<Text>()[1];
        textPlayerEnergy = GameObject.Find("GodModeTextPlayerPoints").GetComponentsInChildren<Text>()[1];
        textEnemiesOnField = GameObject.Find("GodModeTextEnemysCounter").GetComponentsInChildren<Text>()[1];

        isGodModeActive = this.GetComponent<Canvas>().gameObject.activeSelf;
		this.ToggleActivity ();
    }

    void Update()
    {
        if (isGodModeActive) {
            if (Input.GetKeyDown(KeyCode.P))
            {
                this.ToggleDeathLessMode();
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                this.ToggleFullLightMode();
                GameObject.Find("Player").GetComponent<ViewSwitch>().GenerateCamera(); 
            }

            textIsDeathless.text = IsDeathLessMode().ToString();
            textFullLight.text = IsFullLightMode().ToString();
        }

    }

    public bool IsDeathLessMode()
    {
        return this.isGodModeActive && this.isDeathLess;
    }

    public bool IsFullLightMode()
    {
        return this.isGodModeActive && this.isFullLight;
    }

    public void ToggleActivity()
    {
        this.isGodModeActive = !this.GetComponent<Canvas>().gameObject.activeSelf;

        this.GetComponent<Canvas>().gameObject.SetActive(this.isGodModeActive);
    }

    public void UpdateTextFieldPlayerEnergy(float energy)
    {
        if (isGodModeActive) {
            textPlayerEnergy.text = energy.ToString();
        }
    }

    public void ToggleDeathLessMode()
    {
        this.isDeathLess = !this.isDeathLess;
    }

    public void ToggleFullLightMode()
    {
        this.isFullLight = !this.isFullLight;
    }
}
