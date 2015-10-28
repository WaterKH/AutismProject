using UnityEngine;
using System.Collections;

public class AddCurrency : Money {

	public AddCurrency()
	{/* Intentionally left blank */}

	public void addDollar(string value)
	{
		base.value += base.billDictionary[value];
	}
	public void addOneDollar()
	{
		base.value += base.billDictionary["one"];
	}
	public void addTwoDollars()
	{
		base.value += base.billDictionary["two"];
	}
	public void addFiveDollars()
	{
		base.value += base.billDictionary["five"];
	}
	public void addTenDollars()
	{
		base.value += base.billDictionary["ten"];
	}
	public void addTwentyDollars()
	{
		base.value += base.billDictionary["twenty"];
	}
	public void addFiftyDollars()
	{
		base.value += base.billDictionary["fifty"];
	}
	public void addHundredDollars()
	{
		base.value += base.billDictionary["hundred"];
	}

	public void addCoin(string value)
	{
		base.value += base.coinDictionary[value];
	}
	public void addPenny()
	{
		base.value += base.coinDictionary["penny"];
	}
	public void addNickel()
	{
		base.value += base.coinDictionary["nickel"];
	}
	public void addDime()
	{
		base.value += base.coinDictionary["dime"];
	}
	public void addQuarter()
	{
		base.value += base.coinDictionary["quarter"];
	}
	public void addHalfDollar()
	{
		base.value += base.coinDictionary["halfDollar"];
	}
	public void addFullDollar()
	{
		base.value += base.coinDictionary["fullDollar"];
	}

}
