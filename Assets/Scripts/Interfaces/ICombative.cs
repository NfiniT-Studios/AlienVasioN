using UnityEngine;

/// <summary>Interface utilized by all objects capable of combative actions.</summary>
public interface ICombative
{
    int StartingHealth { get; set; }
    int CurrentHealth { get; set; }
    int BaseDamage { get; set; }
    int BaseArmor { get; set; }
    ICombative Target { get; set; }
    void TakeDamage(int damageToTake);
    void Die();
    void IssueDamage(int damageToGive, ICombative objectToDamage);
    void Kill(ICombative objectToKill);
}
