using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Range1 : MonoBehaviour {
	
	int max;
	int min;
	int guess;
	
	int maxGuessesAllowed = 10;
	
	public Text theGuess;
	public Text numberLeft;
	
	// Use this for initialization - beginning of game
	void Start () {
		StartGame();
		theGuess.text = guess.ToString();
	}
	

	
	public void GuessHigher() {
		if (guess == 1000)
		{
			Application.LoadLevel("Cheat");
		}
		else
		{
			min = guess;
			NextGuess ();
		}
	}	
	
	public void GuessLower() {
		if (guess == 1)
		{
			Application.LoadLevel("Cheat");
		}
		else
		{
			max = guess;
			NextGuess ();
		}
	}
	
	
	public void StartGame() {
		
		min = 0;
		max = 1001;			
		guess = (Random.Range(min,max));
		
		max = max + 1 ;
		
	}
	
	
	
	
	void NextGuess() {
		
		guess = (Random.Range((min + 1), (max - 1))) ;
		theGuess.text = guess.ToString(); //changes guess to be a string that will show up on screen
		//theguess is a variable and .text is an attribute of that variable
		
		
		maxGuessesAllowed = maxGuessesAllowed - 1;
		numberLeft.text = maxGuessesAllowed.ToString(); //shows how many guesses are left before you fail
		
		if (guess >= max || guess <= min) {
			Application.LoadLevel("Cheat");
		}
		
		if (maxGuessesAllowed < 0) {
			Application.LoadLevel("Win");
			
		}
		
		
		
	}
}
