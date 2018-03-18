using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CombativeShip
{
    public override void Die()
    {
    }

    public override void IssueDamage(int damageToGive, ICombative objectToDamage)
    {
    }

    public override void Kill(ICombative objectToKill)
    {
    }

    public override void RemoveIdentity()
    {
    }

    public override void RevealIdentity()
    {
    }

    public override void StartAccelerating()
    {
        Vector2 newAccelerationDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        RB.velocity = Vector2.Lerp(RB.velocity, (newAccelerationDirection * ShipAccelerationSpeed * Time.deltaTime), .01f);
    }

    public override void StartRotating()
    {
        Vector3 targetVector = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        Quaternion targetHeading = Quaternion.LookRotation(Vector3.forward, targetVector);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetHeading, ShipRotationSpeed * Time.deltaTime);
    }

    public override void StopAccelerating()
    {
    }
    public override void StopRotating()
    {
    }
    public override void TakeDamage(int damageToTake)
    {
    }
    
    // Use this for initialization
    void Start () {
        InputManager.OnAccelerationStart += StartAccelerating;
        InputManager.OnAccelerationStop += StopAccelerating;
        InputManager.OnRotationStart += StartRotating;
	}
    private void OnDestroy()
    {
        InputManager.OnAccelerationStart -= StartAccelerating;
        InputManager.OnAccelerationStop -= StopAccelerating;
    }

    // Update is called once per frame
    void Update () {
        //TODO: Move this into a stand-alone script so as to separate player functionality from camera functionality.
        Camera.main.transform.position = new Vector3(RB.position.x, RB.position.y, Camera.main.transform.position.z);
    }
    private void OnDrawGizmos()
    {
        //TODO: Remove all editor-related effects into Editor-specific scripts.
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position, Vector3.up);
    }
}
