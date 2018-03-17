using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberMaster : MonoBehaviour {
    public int min;
    public int max;
    public int myNumber;
    public int guess;

    public Text guessText;
    public InputField myGuessField;
    public Button startButton;
    public bool gameStarted = false;

	// Use this for initialization
	void Start () {
       // InitGame();
	}
	
	// Update is called once per frame
	void Update () {
        if (gameStarted)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                max = guess;
                GuessNextNumber();
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                min = guess;
                GuessNextNumber();

            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                StartGame();
            }
        }
    }

    void InitGame() {

    }

    void CheckInput()
    {
        if (myGuessField.text == "")
        {
            guessText.text = "";
        }
        else
        {
            //startButton
        }
    }

    void StartGame()
    {
        Debug.ClearDeveloperConsole();
        gameStarted = true;
        min = 0;
        max = 1000;
        myGuessField.readOnly = true;

        myNumber = int.Parse(myGuessField.text);
        Debug.Log("Welcom to NumberMaster!");
        GuessNextNumber();
    }

    void GuessNextNumber() {
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
        Debug.Log("Your number is " + guess + "?");
        Debug.Log("Info: Press left arrow if number is less, right arrow if number is greather or enter if number match!");
    }


}
