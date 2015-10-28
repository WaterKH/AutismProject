using UnityEngine;
using System.Collections;

public class AddCurrency : MonoBehaviour {

	public Game theGame;
	public Money aMoney = new Money();

	/*
	 * Methods to add values to the left of the decimal point
	 * 	ie - 14.XX; Adds dollars
	 */ 
	public void addDollar(string value)
	{
		aMoney.value += theGame.billDictionary[value];
	}
	public void addOneDollar()
	{
		aMoney.value += theGame.billDictionary["one"];
	}
	public void addTwoDollars()
	{
		aMoney.value += theGame.billDictionary["two"];
	}
	public void addFiveDollars()
	{
		aMoney.value += theGame.billDictionary["five"];
	}
	public void addTenDollars()
	{
		aMoney.value += theGame.billDictionary["ten"];
	}
	public void addTwentyDollars()
	{
		aMoney.value += theGame.billDictionary["twenty"];
	}
	public void addFiftyDollars()
	{
		aMoney.value += theGame.billDictionary["fifty"];
	}
	public void addHundredDollars()
	{
		aMoney.value += theGame.billDictionary["hundred"];
	}
	
	/*
	 * Methods to add values to the right of the decimal point
	 * 	ie - XX.45; Adds cents
	 */ 
	public void addCoin(string value)
	{
		aMoney.value += theGame.coinDictionary[value];
	}
	public void addPenny()
	{
		aMoney.value += theGame.coinDictionary["penny"];
	}
	public void addNickel()
	{
		aMoney.value += theGame.coinDictionary["nickel"];
	}
	public void addDime()
	{
		aMoney.value += theGame.coinDictionary["dime"];
	}
	public void addQuarter()
	{
		aMoney.value += theGame.coinDictionary["quarter"];
	}
	public void addHalfDollar()
	{
		aMoney.value += theGame.coinDictionary["halfDollar"];
	}
	public void addFullDollar()
	{
		aMoney.value += theGame.coinDictionary["fullDollar"];
	}

}
