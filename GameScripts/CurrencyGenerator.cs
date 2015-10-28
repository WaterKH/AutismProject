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

	public double GenerateRandomValue()
	{
		while(theGame.currentGameState == theGame.GameState.moneyExchanger)
		{
			if(!onGoingTransaction)
			{
				//Randomly Generate sum here
			}
		}
	}

}
