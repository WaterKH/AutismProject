using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CashRegister : MonoBehaviour {

	public Game theGame;
	public double accruedChange = 0;
	public double totalChangeInRegister = 0; // Not fully implemented yet
	public CustomerPayment customerPayment;
	public Text displayChange;

	//TODO Add a method that generates the different change neccessary to complete the transaction

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

	public void giveChangeToCustomer()// I need to think of a better function name...
	{
		double changeToMatch = (customerPayment.aMoney.getValue() - customerPayment.customerPayment());
		Debug.Log(changeToMatch.ToString());
		if(accruedChange > changeToMatch)
		{
			Debug.Log("The change you are giving back is too much");
		}
		else if(accruedChange < changeToMatch)
		{
			Debug.Log("The change you are giving back is not enough");
		}
		else
		{
			Debug.Log("You returned the correct change. Congratulations!");
			this.clearAccruedChange();
		}
	}

	public void clearAccruedChange()
	{
		this.accruedChange = 0;
		displayChange.text = this.accruedChange.ToString();
	}

	/*
	 * Methods to add values to the left of the decimal point
	 * 	ie - 14.XX; Adds dollars
	 */ 
	public double addDollar(string value)
	{
		return theGame.billDictionary[value];
	}
	public double addOneDollar()
	{
		return theGame.billDictionary["one"];
	}
	public double addFiveDollars()
	{
		return theGame.billDictionary["five"];
	}
	public double addTenDollars()
	{
		return theGame.billDictionary["ten"];
	}
	public double addTwentyDollars()
	{
		return theGame.billDictionary["twenty"];
	}
	public double addFiftyDollars()
	{
		return theGame.billDictionary["fifty"];
	}
	
	/*
	 * Methods to add values to the right of the decimal point
	 * 	ie - XX.45; Adds cents
	 */ 
	public double addCoin(string value)
	{
		return theGame.coinDictionary[value];
	}
	public double addPenny()
	{
		return theGame.coinDictionary["penny"];
	}
	public double addNickel()
	{
		return theGame.coinDictionary["nickel"];
	}
	public double addDime()
	{
		return theGame.coinDictionary["dime"];
	}
	public double addQuarter()
	{
		return theGame.coinDictionary["quarter"];
	}
}
