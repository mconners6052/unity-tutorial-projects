using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour 
{

    static int max;
    static int min;
    static int guess;

    
    // Use this for initialization
	void Start () 
    {
        Debug.Log("Welcome, mortal! 'Tis I, the Number Wizard!");
        StartGame();
	}

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = (max + min) / 2;
        Debug.Log("Think of a number, then be silent!");
        Debug.Log("The highest number you can pick is " + max + ".");
        Debug.Log("The lowest number you can pick is " + min + ".");
        Debug.Log("Tell me if my guess is higher than, lower than or eqaul to your number.");
        Debug.Log("If it is higher, press the Up arrow. If it is lower, press the Down arrow. If my guess is correct, hit Enter.");
        Debug.Log("Is your number " + guess + "?");
        max += 1;
    }
	 
	// Update is called once per frame
	void Update () 
    {
        bool lowerInput = Input.GetKeyDown(KeyCode.DownArrow);
        bool upperInput = Input.GetKeyDown(KeyCode.UpArrow);
        bool correctInput = Input.GetKeyDown(KeyCode.Return);


        if (lowerInput)
            {
            Debug.Log("Lower, you say...?");
            max = guess; 
            NextGuess();
            }

        else if (upperInput)
            {
             Debug.Log("Higher, you say...?");
             min = guess;
             NextGuess();
            }

        else if (correctInput)
           {
             Debug.Log("Aha! Victory! I! Am! Unstoppable!");
             Debug.Log("Do you dare test me again, mortal?");
             StartGame();
           }

        
	}

    void NextGuess()
    {
     guess = (max + min) / 2;
     Debug.Log("Then is your number " + guess + "?");
    }

    }
