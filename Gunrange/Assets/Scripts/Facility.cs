using UnityEngine;

public class Facility
{
    public int capacity;
    public int currentUsage;
    public float pricePerUse;
    public float maintenanceCost;

    public Facility(int capacity, float pricePerUse, float maintenanceCost)
    {
        this.capacity = capacity;
        this.pricePerUse = pricePerUse;
        this.maintenanceCost = maintenanceCost;
        this.currentUsage = 0;
    }

    // Check if the facility has an available lane
    public bool HasAvailableLane()
    {
        return currentUsage < capacity;
    }

    // Rent out a lane to a customer
    public void RentOutLane()
    {
        if (HasAvailableLane())
        {
            currentUsage++;
            Debug.Log("Lane rented out.");
        }
        else
        {
            Debug.Log("No lanes available.");
        }
    }

    // Simulate the maintenance cost for running the facility
    public void PerformMaintenance()
    {
        Debug.Log("Performing maintenance. Cost: " + maintenanceCost);
    }

    // Free up a lane when a customer is done
    public void FreeLane()
    {
        if (currentUsage > 0)
        {
            currentUsage--;
        }
        Debug.Log("Lane freed.");
    }
}