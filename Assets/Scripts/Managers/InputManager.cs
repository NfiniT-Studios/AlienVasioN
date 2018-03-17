using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class InputManager : MonoBehaviour{
    public delegate void NoArg();
    public static event NoArg OnAccelerationStart;
    public static event NoArg OnAccelerationStop;
    public static event NoArg OnRotationStart;
    public static event NoArg OnRotationStop;
    public static event NoArg OnFiringStart;
    public static event NoArg OnFiringStop;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (OnAccelerationStart != null)
                OnAccelerationStart();
        }
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D))
        {
            if (OnAccelerationStop != null)
                OnAccelerationStop();
        }
    }
}
