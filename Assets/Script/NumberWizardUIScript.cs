using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizardUIScript : MonoBehaviour
{
    int max;
    int min;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        max = max + 1;
    }

    public void HandleHigher()
    {
        min = guess;
        guess = (min + max) / 2;

    }

    public void HandleLower()
    {
        max = guess;
        guess = (min + max) / 2;
    }

    public void HandleCorrect()
    {
        //load next screen
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
            min = guess;
            guess = (min + max) / 2;
            Debug.Log("Guess is" + guess);
        }
        //Detect when the down arrow key is pressed down
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (min + max) / 2;
            Debug.Log("down arrow key was pressed.");
            Debug.Log("Guess is" + guess);
        }

        //Detect when the Return Key is pressed down
        else if
            (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am Genius.");
            StartGame();
        }
    }
}
