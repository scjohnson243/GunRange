using UnityEngine;

public class GameController : MonoBehaviour {

    [SerializeField] private NameGenerator nameGenerator;
    
    Business playerBusiness;
    Facility basicRange;
    Customer customer1;

    void Start()
    {
        // Initialize the business and facilities
        playerBusiness = new Business(startingMoney: 1000);
        basicRange = new Facility(capacity: 5, pricePerUse: 50, maintenanceCost: 20);

        // Add the facility to the business
        playerBusiness.facilities.Add(basicRange);

        // Create a casual shooter customer
        customer1 = new CasualShooter(money: 200, satisfaction: 100, gunPreference: "Pistol",nameGenerator);

        // Customer interaction: Rent a lane and shoot
        if (customer1.RentLane(basicRange))
        {
            playerBusiness.AddMoney(basicRange.pricePerUse);
        }

        // Customer satisfaction
        customer1.CalculateSatisfaction();

        // Pay facility expenses
        playerBusiness.PayExpenses();
    }

    void Update()
    {
        // Here you could implement additional game logic such as upgrades, more customers, etc.
        if (Input.GetKeyDown(KeyCode.U))
        {
            // Upgrade the facility when "U" is pressed
            playerBusiness.UpgradeFacility(basicRange, newCapacity: 10);
        }
    }
}