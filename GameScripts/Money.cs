using UnityEngine;
using System.Collections;

[System.Serializable] // How to get both the bill and the coin... just put it in here?
public class Money {

	public Bill aBill = new Bill();
	public Coin aCoin = new Coin();

	public double value = 0;
	public string tag = "NULL"; // Not sure why I added this...

	public Money()
	{
		value = 0;
		tag = "NULL";
	}
	public Money(int aValue, string aTag)
	{
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
	
}
