using UnityEngine;
using System.Collections;

[System.Serializable]
public class Money {

	//TODO Not sure these are necessary as this is a different approach
	public Bill aBill = new Bill();
	public Coin aCoin = new Coin();

	public decimal value = 0.0m;

	public Money()
	{
		value = 0.0m;
	}
	public Money(decimal aValue)
	{
		this.setValue(aValue);
	}

	public void setValue(decimal aValue)
	{
		value = aValue;
	}

	public decimal getValue()
	{
		return value;
	}
}
