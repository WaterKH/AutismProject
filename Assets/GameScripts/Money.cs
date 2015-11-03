using UnityEngine;
using System.Collections;

[System.Serializable]
public class Money {

	//TODO Not sure these are necessary as this is a different approach
	public Bill aBill = new Bill();
	public Coin aCoin = new Coin();

	public double value = 0;

	public Money()
	{
		value = 0;
	}
	public Money(double aValue)
	{
		this.setValue(aValue);
	}

	public void setValue(double aValue)
	{
		value = aValue;
	}

	public double getValue()
	{
		return value;
	}
}
