using UnityEngine;
using System.Collections;

public class MoneyIns : MonoBehaviour {
	
	public AddCurrency addCurrency = new AddCurrency();

	void Awake()
	{
		addCurrency.addFiftyDollars();
		addCurrency.addNickel();
		Debug.Log(addCurrency.getValue());
	}
}
