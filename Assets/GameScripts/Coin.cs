using UnityEngine;
using System.Collections;

[System.Serializable]
public class Coin {

	public string typeOfCoin = "NULL";

	public Coin()
	{
		typeOfCoin = "NULL";
	}
	public Coin(string aCoin, int aValue)
	{
		this.setTypeOfCoin(aCoin);
	}
	
	public void setTypeOfCoin(string aCoin)
	{
		typeOfCoin = aCoin;
	}

	public string getCoin()
	{
		return typeOfCoin;
	}

}
