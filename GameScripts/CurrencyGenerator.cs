using UnityEngine;
using System.Collections;

public class CurrencyGenerator : MonoBehaviour {

	/*
	 * While current game == MoneyExchanger
	 * 	If onGoingTransaction == false
	 * 	 Randomly generate a sum from AddCurrency
	 * 
	 */
	public Game theGame;
	public bool onGoingTransaction = false;
	public AddCurrency addCurrency = new AddCurrency();

	public double GenerateRandomValue()
	{
		double valueResult = 0.0;
		while(theGame.currentGameState == (int)Game.GameState.moneyExchanger)
		{
			if(!onGoingTransaction)
			{
				//Randomly Generate sum here
				valueResult = addCurrency.aMoney.getValue();
			}
		}
		return valueResult;
	}

}
