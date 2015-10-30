using UnityEngine;
using System.Collections;

public class MoneyIns : MonoBehaviour {

	public AddCurrency addCurrency;

	void Start()
	{
		addCurrency.addFiftyDollars();
		addCurrency.addNickel();
		Debug.Log(addCurrency.aMoney.getValue());
	}
}
