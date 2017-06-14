using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GodModeInitalisizer : MonoBehaviour
{
    private GodMode godmode;

    void Awake()
    {
        godmode = GameObject.Find("CanvasGodMode").GetComponent<GodMode>();
    }

    protected GodMode GetGodMode()
    {
        return this.godmode;
    }
}