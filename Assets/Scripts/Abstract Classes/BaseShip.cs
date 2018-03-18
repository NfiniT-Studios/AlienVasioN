using UnityEngine;

/// <summary>Base abstract class for all in-game ships.  Derived from BaseObject</summary>
public abstract class BaseShip : BaseObject
{
    [Space(10)]
    [Header("Base Ship Properties")]
    [Tooltip("Ship's Acceleration Speed")]
    [SerializeField]
    private float shipAccelerationSpeed = 1.0f;
    [Tooltip("Ship's Turning Speed")]
    [SerializeField]
    private float shipRotationSpeed = 1.0f;
    private Rigidbody2D rb;





    public Rigidbody2D RB
    {
        get
        {
            return rb;
        }

        set
        {
            rb = value;
        }
    }
    public float ShipAccelerationSpeed
    {
        get
        {
            return shipAccelerationSpeed;
        }

        set
        {
            shipAccelerationSpeed = value;
        }
    }
    public float ShipRotationSpeed
    {
        get
        {
            return shipRotationSpeed;
        }

        set
        {
            shipRotationSpeed = value;
        }
    }





    public override void Awake()
    {
        base.Awake();
        RB = gameObject.GetComponent<Rigidbody2D>();
        if (RB == null)
            print(gameObject.name + " does not have an attached rigidbody2D component!");
    }
    abstract public void StartAccelerating();
    abstract public void StopAccelerating();
    abstract public void StartRotating();
    abstract public void StopRotating();
}    
