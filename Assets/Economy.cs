using UnityEngine;
using TMPro;

public class Economy : MonoBehaviour
{
    public int startingBalance = 100; // starting balance
    public TextMeshProUGUI balanceText; // assign the TextMeshProUGUI object to display the balance
    private int currentBalance; // current balance

    void Start()
    {
        currentBalance = startingBalance; // initialize the balance
        UpdateBalanceText(); // update the TextMeshProUGUI object
    }

    // add or subtract funds
    public void AddFunds(int amount)
    {
        currentBalance += amount;
        UpdateBalanceText();
    }

    // check if enough funds are available
    public bool CanAfford(int amount)
    {
        return currentBalance >= amount;
    }

    // update the TextMeshProUGUI object
    void UpdateBalanceText()
    {
        balanceText.text = currentBalance.ToString() + " zł";
    }
}
