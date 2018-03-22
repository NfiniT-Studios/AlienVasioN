using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Base class for all projectile objects.  </summary>
public abstract class BaseProjectile : MonoBehaviour
{
    [Space(10)][Header("Basic Projectile Stats")]
    [Tooltip("Base projectile damage")][SerializeField]
    private int projectileDamage;
    [Tooltip("Base projectile speed")][SerializeField]
    private int projectileSpeed;
    /// <summary>Reference to object's rigidbody2d component.</summary>
    private Rigidbody2D rb;





    /// <summary>Accessor for object's rigidbody2d component.</summary>
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





    /// <summary>Calls TrajectoryPath automatically!  Sends projectile on its way!</summary>
    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        TrajectoryPath();
    }





    /// <summary>Movement mechanics of projectile. Overrideable.</summary>
    virtual public void TrajectoryPath()
    {
        RB.AddForce(transform.up * projectileSpeed);
    }
    /// <summary>Mechanic to execute when hitting an object. Overrideable.</summary>
    virtual public void OnCollisionEnter(Collision collision)
    {
        ICombative combativeObject = collision.gameObject.GetComponent<ICombative>();
        if (combativeObject != null)
        {
            DamageObject(combativeObject);
        }
        Destroy(this);
    }
    /// <summary>Damage mechanics when having hit an ICombative target. Overridable.</summary>
    virtual public void DamageObject(ICombative target)
    {
            target.TakeDamage(projectileDamage);
    }
}
