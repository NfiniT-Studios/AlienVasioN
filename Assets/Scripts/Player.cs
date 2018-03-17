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
        Vector2 newAccelerationDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        RB.velocity = Vector2.Lerp(RB.velocity, (newAccelerationDirection * ShipAccelerationSpeed * Time.deltaTime), .01f);
    }

    public override void StopAccelerating()
    {
    }

    public override void TakeDamage(int damageToTake)
    {
    }

    // Use this for initialization
    void Start () {
        InputManager.OnAccelerationStart += StartAccelerating;
        InputManager.OnAccelerationStop += StopAccelerating;
	}
    private void OnDestroy()
    {
        InputManager.OnAccelerationStart -= StartAccelerating;
        InputManager.OnAccelerationStop -= StopAccelerating;
    }

    // Update is called once per frame
    void Update () {
	}
}
