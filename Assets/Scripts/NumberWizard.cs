using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;
	
	int maxGuessesAllowed = 17;
	
	public Text theguess;

	// Use this for initialization - beginning of game
	void Start () {
		StartGame();
		StartGame2();
		StartGame3();
		theguess.text = guess.ToString();
	}
		
	public void GuessHigher() {
		min = guess;
		NextGuess ();
			
	}	
	
	public void GuessLower() {
		max = guess;
		NextGuess ();
	
	}
	

	public void StartGame() {
		
		min = 1;
		max = 1000;			
		guess = (Random.Range(min, max)) ;
		
		max = max + 1 ;
		
	}
	
	public void StartGame2() {
		
		min = 1;
		max = 10000;
		guess = (Random.Range(min, max)) ;
		
		max = max + 1 ;
	
	}
	
	public void StartGame3() {
		
		min = 1;
		max = 30000;
		guess = (Random.Range(min, max)) ;
	
		max = max + 1 ;
		
	}


		
	void NextGuess() {
		
		guess = (Random.Range(min, max)) ;
		theguess.text = guess.ToString(); //changes guess to be a string that will show up on screen
		//theguess is a variable and .text is an attribute of that variable
		
		maxGuessesAllowed = maxGuessesAllowed - 1;
		
		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel("Win");
		
		}
		
	}
}
