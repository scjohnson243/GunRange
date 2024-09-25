using UnityEngine;
using System.Collections.Generic;

public class Business
{
    public float money;
    public float satisfactionLevel;
    public List<Facility> facilities = new List<Facility>();

    public Business(float startingMoney)
    {
        this.money = startingMoney;
    }

    // Add money when customers pay
    public void AddMoney(float amount)
    {
        money += amount;
        Debug.Log("Money earned: " + amount);
    }

    // Pay for maintenance of all facilities
    public void PayExpenses()
    {
        float totalExpenses = 0;
        foreach (Facility facility in facilities)
        {
            totalExpenses += facility.maintenanceCost;
            facility.PerformMaintenance();
        }
        money -= totalExpenses;
        Debug.Log("Total maintenance cost: " + totalExpenses);
    }

    // Upgrade a facility, for example, increasing capacity
    public void UpgradeFacility(Facility facility, int newCapacity)
    {
        facility.capacity = newCapacity;
        Debug.Log("Facility upgraded to new capacity: " + newCapacity);
    }

    // Check business progress
    public void CheckProgress()
    {
        // Placeholder for business progression logic (unlocking new features)
        Debug.Log("Checking business progress...");
    }
}