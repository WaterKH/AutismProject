using UnityEngine;
using System.Collections;

[System.Serializable]
public class Bill {

	public string typeOfBill = "NULL";

	public Bill()
	{
		typeOfBill = "NULL";
	}
	public Bill(string aBill)
	{
		this.setTypeOfBill(aBill);
	}

	public void setTypeOfBill(string aBill)
	{
		typeOfBill = aBill;
	}

	public string getBill()
	{
		return typeOfBill;
	}

}
