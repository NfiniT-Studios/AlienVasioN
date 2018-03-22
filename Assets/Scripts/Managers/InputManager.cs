using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Manager class for controlling input-driven event calls.</summary>
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
	
    /// <summary>Continuous detection of input and calling of appropriate input-related events.</summary>
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
        if (Input.GetKeyDown(KeyCode.Mouse0) && OnFiringStart != null)
        {
            OnFiringStart();
        }

        if (OnRotationStart != null)
            OnRotationStart();
    }
}
