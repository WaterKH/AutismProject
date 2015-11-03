using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CustomerPayment : MonoBehaviour {

	/*
	 * While current game == MoneyExchanger
	 * 	If onGoingTransaction == false
	 * 	 Randomly generate a sum from AddCurrency
	 */
	public Game theGame;
	public bool onGoingTransaction = false;
	public double[] payments = {1.25, 2.50, 3.80, 4.13, 5.01};
	public int incrementer = 0;
	public Text displayPrice;
	public Text displayCustomerPayment;
	public Money aMoney = new Money();
	public double customerMoney = 0.0;

	public void generatePriceFromPayments()//GenerateRandomValue()
	{
		if(theGame.currentGameState == (int)Game.GameState.moneyExchanger)
		{
			if(!onGoingTransaction && incrementer < payments.Length)
			{
				aMoney = new Money(payments[incrementer]);
				Debug.Log("Price: " + displayPrice.text);
				Debug.Log("Customer Payment: " + displayCustomerPayment.text);
				Debug.Log("Price: " + aMoney.getValue().ToString());
				Debug.Log("Customer: " + this.customerPayment().ToString());
				displayPrice.text = aMoney.getValue().ToString(); 
				displayCustomerPayment.text =  this.customerPayment().ToString();
				++incrementer;
			}
		}
	}

	public double customerPayment() // Dollars Only
	{
		while(customerMoney <= aMoney.getValue())
		{
			if(aMoney.getValue () == 0.0)
			{
				break;
			}

			if(aMoney.getValue() >= 1.00 && aMoney.getValue() < 5.00)
			{
				customerMoney += theGame.billDictionary["one"];
			}
			else if(aMoney.getValue() >= 5.00 && aMoney.getValue () < 10)
			{
				customerMoney += theGame.billDictionary["five"];
			}
			else if(aMoney.getValue() >= 10 && aMoney.getValue() < 20)
			{
				customerMoney += theGame.billDictionary["ten"];
			}
			else if(aMoney.getValue() >= 20 && aMoney.getValue() < 50)
			{
				customerMoney += theGame.billDictionary["twenty"];
			}
			else
			{
				customerMoney += theGame.billDictionary["fifty"];
			}
		}
		return customerMoney;
	}
}
