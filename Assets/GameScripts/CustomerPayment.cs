using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CustomerPayment : MonoBehaviour {
	
	public Game theGame;
	public bool onGoingTransaction = false;
	public decimal[] payments = {1.25m, 2.50m, 3.80m, 4.13m, 5.01m};
	public int indexOfPayments = 0;
	public Text displayPrice;
	public Text displaycustomerPayment;
	public Money aMoney = new Money();
	public decimal customerPaymentValue = 0.0m;

	/*
	 * Generates a value from our decimal array (payments)
	 * 
	 * IF our current game state equals the instance of the game "Money Exchanger"
	 * 	IF we do not have another transaction (ie a customer) going on AND our index
	 * 	  	is less than the size of our array.
	 * 	 We create a new instance of Money with the value at our index within payments.
	 * 	 We then set our price text value to be displayed on screen to the value we 
	 * 		found at our index within our decimal array (payments). We also set our
	 * 		customer's payment equal to the decimal value we get from the function call,
	 * 		customerPayment. Finally, we increment the index we are pointing to within
	 * 		our decimal array (payments).
	 * 
	 */
	public void generatePriceFromPayments()//GenerateRandomValue()
	{
		if(theGame.currentGameState == (int)Game.GameState.moneyExchanger)
		{
			if(!onGoingTransaction && indexOfPayments < payments.Length)
			{
				aMoney = new Money(payments[indexOfPayments]);
				displayPrice.text = aMoney.getValue().ToString(); 
				displaycustomerPayment.text =  this.customerPayment().ToString();
				++indexOfPayments;
				onGoingTransaction = true;
			}
			else if(onGoingTransaction)
			{
				Debug.Log("Complete the current customer before continuing.");
			}
		}
	}

	/*
	 * Function that returns the amount the customer will pay with
	 * 
	 * WHILE our customer's payment is less than the total price of the item
	 * 	IF the price of the item is equal to zero, we can break from the loop.
	 * 	
	 * 	We then test each bill (ie 1, 5, 10, 20, 50) to see if the price lies within
	 * 		each limit, and if so, we add to the customer's payment.
	 * 
	 * Finally, we return our customer's payment.
	 * 
	 * [NOT SURE THIS WILL WORK WITH A WHILE LOOP]
	 */ 
	public decimal customerPayment() // Dollars Only
	{
		while(customerPaymentValue <= aMoney.getValue())
		{
			if(aMoney.getValue () == 0.00m)
			{
				break;
			}

			if(aMoney.getValue() >= 1.00m && aMoney.getValue() < 5.00m)
			{
				customerPaymentValue += theGame.billDictionary["one"];
			}
			else if(aMoney.getValue() >= 5.00m && aMoney.getValue () < 10.00m)
			{
				customerPaymentValue += theGame.billDictionary["five"];
			}
			else if(aMoney.getValue() >= 10.00m && aMoney.getValue() < 20.00m)
			{
				customerPaymentValue += theGame.billDictionary["ten"];
			}
			else if(aMoney.getValue() >= 20.00m && aMoney.getValue() < 50.00m)
			{
				customerPaymentValue += theGame.billDictionary["twenty"];
			}
			else
			{
				customerPaymentValue += theGame.billDictionary["fifty"];
			}
		}
		return customerPaymentValue;
	}
}
