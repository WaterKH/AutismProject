using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Game : MonoBehaviour {

	// These Gamestates will be for each game. Not sure we need them, but if so we will have them.
	public enum GameState
	{
		menu = 0,
		moneyExchanger = 1,
		otherGame1 = 2,
		otherGame2 = 3,
	};
	public int currentGameState = 1; // Dummy value set because 0 is menu
	public Dictionary<string, decimal> coinDictionary = new Dictionary<string, decimal>();
	public Dictionary<string, decimal> billDictionary = new Dictionary<string, decimal>();

	/*
	 * Methods used in MoneyExchanger
	 * 	
	 * 	Initialized here because I don't want to keep creating dictionaries within the Bill/ Coin/ Money
	 * 		classes.
	 */
	public void setUpCurrency()
	{
		billDictionary.Add ("one", 1.00m);
		billDictionary.Add ("five", 5.00m);
		billDictionary.Add ("ten", 10.00m);
		billDictionary.Add ("twenty", 20.00m);
		billDictionary.Add ("fifty", 50.00m);

		coinDictionary.Add ("penny", 0.01m);
		coinDictionary.Add ("nickel", 0.05m);
		coinDictionary.Add ("dime", 0.10m);
		coinDictionary.Add ("quarter", 0.25m);
	}

	// Use this for initialization
	void Awake () 
	{
		///////////////////////////////////////////
		/////// Call MoneyExchanger Methods ///////
		///////////////////////////////////////////
		setUpCurrency();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
