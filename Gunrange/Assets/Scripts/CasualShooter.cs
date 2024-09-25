using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasualShooter : Customer
{
    public CasualShooter(float money, float satisfaction, string gunPreference, NameGenerator name) : 
        base(money, satisfaction, gunPreference, name)
    { }

    public override void CalculateSatisfaction()
    {
        base.CalculateSatisfaction();
        // Casual shooters might have simpler needs
       // Debug.Log("Causal Shooter Satisifaction: " + satisfaction);
    }
}
