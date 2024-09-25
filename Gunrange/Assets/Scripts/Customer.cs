using UnityEngine;

public class Customer : MonoBehaviour {
    [SerializeField] private string name;
    [SerializeField] private float money;
    [SerializeField] private float satisfaction;
    [SerializeField] private string gunPreference;
    
    //constructor, reference to NameGenerator
    public Customer(float money, float satisfaction, string gunPreference, NameGenerator nameGenerator)
    {
        this.name = nameGenerator.GenerateRandomName();
        this.money = money;
        this.satisfaction = satisfaction;
        this.gunPreference = gunPreference;
    }
    
    //method to rent a lane
    public virtual bool RentLane(Facility facility)
    {
        if (facility.HasAvailableLane())
        {
            money -= facility.pricePerUse;
            facility.RentOutLane();
            Debug.Log($"{name} rented a lane!");
            return true;
        }
        else
        {
            satisfaction -= 10; // no lane available, decrease satisfaction
            Debug.Log($"{name} couldn't find a available lane, --Satisfaction.");
            return false;
        }
    }
    
    //calculate Satisfaction
    public virtual void CalculateSatisfaction()
    {
        if (satisfaction < 50)
        {
            Debug.Log($"{name} is unhappy");
        }
        else
        {
            Debug.Log($"{name} is happy!");
        }
        
    }
    
}
