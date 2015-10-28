using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable] // How to get both the bill and the coin... just put it in here?
public class Money {

	public Bill aBill = new Bill();
	public Coin aCoin = new Coin();
	public AddCurrency addCurrency = new AddCurrency();

	public double value = 0;
	public string tag = "NULL";
	public Dictionary<string, double> billDictionary = new Dictionary<string, double>();
	public Dictionary<string, double> coinDictionary = new Dictionary<string, double>();

	public Money()
	{
		setUpCurrency();
		tag = "NULL";
	}
	public Money(int aValue, string aTag)
	{
		setUpCurrency();
		this.setValue(aValue);
		this.setTag(aTag);
	}

	public void setValue(int aValue)
	{
		value = aValue;
	}
	public void setTag(string aTag)
	{
		tag = aTag;
	}

	public double getValue()
	{
		return value;
	}
	public string getTag()
	{
		return tag;
	}

	public void setUpCurrency()
	{
		billDictionary.Add ("one", 1.00);
		billDictionary.Add ("two", 2.00);
		billDictionary.Add ("five", 5.00);
		billDictionary.Add ("ten", 10.00);
		billDictionary.Add ("twenty", 20.00);
		billDictionary.Add ("fifty", 50.00);
		billDictionary.Add ("hundred", 100.00);
		
		coinDictionary.Add ("penny", 0.01);
		coinDictionary.Add ("nickel", 0.05);
		coinDictionary.Add ("dime", 0.10);
		coinDictionary.Add ("quarter", 0.25);
		coinDictionary.Add ("halfdollar", 0.50);
		coinDictionary.Add ("fulldollar", 1.00);
	}
}
