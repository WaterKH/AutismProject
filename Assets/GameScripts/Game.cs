using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Game : MonoBehaviour {
	
	public enum GameState
	{
		menu = 0,
		moneyExchanger = 1,
		otherGame1 = 2,
		otherGame2 = 3,
	};
	public int currentGameState = 1; // Dummy value set because 0 is menu
	public Dictionary<string, double> coinDictionary = new Dictionary<string, double>();
	public Dictionary<string, double> billDictionary = new Dictionary<string, double>();

	/*
	 * Methods used in MoneyExchanger
	 * 	
	 * 	Initialized here because I don't want to keep creating dictionaries within the Bill/ Coin/ Money
	 * 		classes.
	 */
	public void setUpCurrency()
	{
		billDictionary.Add ("one", 1.00);
		billDictionary.Add ("five", 5.00);
		billDictionary.Add ("ten", 10.00);
		billDictionary.Add ("twenty", 20.00);
		billDictionary.Add ("fifty", 50.00);

		coinDictionary.Add ("penny", 0.01);
		coinDictionary.Add ("nickel", 0.05);
		coinDictionary.Add ("dime", 0.10);
		coinDictionary.Add ("quarter", 0.25);
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
