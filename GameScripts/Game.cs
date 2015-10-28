using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {
	
	public enum GameState
	{
		menu = 0,
		moneyExchanger = 1,
		otherGame1 = 2,
		otherGame2 = 3,
	};
	public int currentGameState = -1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
