using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Base class for all ships that utilize the ICombative interface to become combat-ready.</summary>
public abstract class CombativeShip : BaseShip, ICombative
{
    [Space(10)]
    [Header("Combative Ship Properties")]
    [Tooltip("Ship's Starting Health")]
    [SerializeField]
    private int shipStartingHealth;
    [Tooltip("Ship's Base Damage.")]
    [SerializeField]
    private int shipBaseDamage = 1;
    [Tooltip("Ship's Base Armor")]
    [SerializeField]
    private int shipBaseArmor = 1;
    private int currentHealth;
    private ICombative target;





    public int StartingHealth
    {
        get
        {
            return shipStartingHealth;
        }

        set
        {
            shipStartingHealth = value;
        }
    }
    public int CurrentHealth
    {
        get
        {
            return currentHealth;
        }
        set
        {
            currentHealth = value;
        }
    }
    public int BaseDamage
    {
        get
        {
            return shipBaseDamage;
        }
        set
        {
            shipBaseDamage = value;
        }
    }
    public int BaseArmor
    {
        get
        {
            return shipBaseArmor;
        }
        set
        {
            shipBaseArmor = value;
        }
    }
    public ICombative Target
    {
        get
        {
            return target;
        }

        set
        {
            target = value;
        }
    }





    abstract public void Die();
    abstract public void IssueDamage(int damageToGive, ICombative objectToDamage);
    abstract public void Kill(ICombative objectToKill);
    abstract public void TakeDamage(int damageToTake);
}
