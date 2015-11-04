using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CashRegister : MonoBehaviour {

	public Game theGame;
	public decimal accruedChange = 0.0m;
	public decimal totalChangeInRegister = 0.0m; // Not fully implemented yet
	public CustomerPayment customerPayment;
	public Text displayChange;

	//TODO Add a method that generates the different change neccessary to complete the transaction

	/*
	 * Adds change to the total change we have accrued. 
	 * 
	 * We pass in the button pushed and switch on its name. We then add to our total change the 
	 * 	value that is associated with the name (ie 1 - one dollar, .25 - quarter). We then 
	 * 	update our text variable to display the current change we have.
	 * 
	 */ 
	public void addToAccruedChange(Button aButton)
	{
		string currencyName = aButton.name;

		switch(currencyName)
		{
		//Dollars first
		case "1Dollar":
			this.accruedChange += this.addOneDollar();
			break;
		case "5Dollars":
			this.accruedChange += this.addFiveDollars();
			break;
		case "10Dollars":
			this.accruedChange += this.addTenDollars();
			break;
		case "20Dollars":
			this.accruedChange += this.addTwentyDollars();
			break;
		case "50Dollars":
			this.accruedChange += this.addFiftyDollars();
			break;
		//Coins next
		case "Penny":
			this.accruedChange += this.addPenny();
			break;
		case "Nickel":
			this.accruedChange += this.addNickel();
			break;
		case "Dime":
			this.accruedChange += this.addDime();
			break;
		case "Quarter":
			this.accruedChange += this.addQuarter();
			break;
		default:
			break;
		}

		displayChange.text = this.accruedChange.ToString();
	}

	/*
	 * Checks if the change we are returning is correct.
	 * 
	 * We first create a decimal instance (changeToMatch) which is our current price of the 
	 * 	item decremented by the value returned by the method customerPayment which is
	 * 	the dollar amount the customer is paying with. 
	 * IF our change is greater than our decimal instance (changeToMatch) we print out that
	 * 	we have given too much.
	 * ELSE IF our change is less than our decimal instance (changeToMatch) we print out that
	 * 	we have given too little.
	 * ELSE we know we have given the correct amount and clear our change to get ready for
	 * 	the next customer.
	 */ 
	public void giveChangeToCustomer()// I need to think of a better function name...
	{
		decimal changeToMatch = (customerPayment.customerPayment() - customerPayment.aMoney.getValue());

		if(accruedChange > changeToMatch)
		{
			Debug.Log("The change you are giving back is too much");
		}
		else if(accruedChange < changeToMatch)
		{
			Debug.Log("The change you are giving back is not enough");
		}
		else if(accruedChange == changeToMatch)
		{
			Debug.Log("You returned the correct change. Congratulations!");
			this.clearAccruedChange();
			customerPayment.onGoingTransaction = false;
			customerPayment.generatePriceFromPayments();
		}
	}

	/*
	 * Clears the total change we have.
	 * 
	 * We set our change to 0. We then update our text variable to display the 
	 * 	current change we have.
	 * 
	 */ 
	public void clearAccruedChange()
	{
		this.accruedChange = 0;
		displayChange.text = this.accruedChange.ToString();
	}

	/*
	 * Methods to add values to the left of the decimal point
	 * 	ie - 14.XX; Adds dollars
	 */ 
	public decimal addDollar(string value)
	{
		return theGame.billDictionary[value];
	}
	public decimal addOneDollar()
	{
		return theGame.billDictionary["one"];
	}
	public decimal addFiveDollars()
	{
		return theGame.billDictionary["five"];
	}
	public decimal addTenDollars()
	{
		return theGame.billDictionary["ten"];
	}
	public decimal addTwentyDollars()
	{
		return theGame.billDictionary["twenty"];
	}
	public decimal addFiftyDollars()
	{
		return theGame.billDictionary["fifty"];
	}
	
	/*
	 * Methods to add values to the right of the decimal point
	 * 	ie - XX.45; Adds cents
	 */ 
	public decimal addCoin(string value)
	{
		return theGame.coinDictionary[value];
	}
	public decimal addPenny()
	{
		return theGame.coinDictionary["penny"];
	}
	public decimal addNickel()
	{
		return theGame.coinDictionary["nickel"];
	}
	public decimal addDime()
	{
		return theGame.coinDictionary["dime"];
	}
	public decimal addQuarter()
	{
		return theGame.coinDictionary["quarter"];
	}
}
