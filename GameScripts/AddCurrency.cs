using UnityEngine;
using System.Collections;

public class AddCurrency : Money {

	public Game theGame;
	
	public AddCurrency() // Initializes the theGame variable in order to access the currency values
	{
		theGame = GameObject.FindGameObjectWithTag("GameDriver").GetComponent<Game>();
	}

	/*
	 * Methods to add values to the left of the decimal point
	 * 	ie - 14.XX; Adds dollars
	 */ 
	public void addDollar(string value)
	{
		base.value += theGame.billDictionary[value];
	}
	public void addOneDollar()
	{
		base.value += theGame.billDictionary["one"];
	}
	public void addTwoDollars()
	{
		base.value += theGame.billDictionary["two"];
	}
	public void addFiveDollars()
	{
		base.value += theGame.billDictionary["five"];
	}
	public void addTenDollars()
	{
		base.value += theGame.billDictionary["ten"];
	}
	public void addTwentyDollars()
	{
		base.value += theGame.billDictionary["twenty"];
	}
	public void addFiftyDollars()
	{
		base.value += theGame.billDictionary["fifty"];
	}
	public void addHundredDollars()
	{
		base.value += theGame.billDictionary["hundred"];
	}

	
	/*
	 * Methods to add values to the right of the decimal point
	 * 	ie - XX.45; Adds cents
	 */ 
	public void addCoin(string value)
	{
		base.value += theGame.coinDictionary[value];
	}
	public void addPenny()
	{
		base.value += theGame.coinDictionary["penny"];
	}
	public void addNickel()
	{
		base.value += theGame.coinDictionary["nickel"];
	}
	public void addDime()
	{
		base.value += theGame.coinDictionary["dime"];
	}
	public void addQuarter()
	{
		base.value += theGame.coinDictionary["quarter"];
	}
	public void addHalfDollar()
	{
		base.value += theGame.coinDictionary["halfDollar"];
	}
	public void addFullDollar()
	{
		base.value += theGame.coinDictionary["fullDollar"];
	}

}
