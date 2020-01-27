using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizardUIScript : MonoBehaviour
{
    [SerializeField]int max;
    [SerializeField]  int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        NextGuess();
        max = max + 1;
    }

    public void HandleHigher()
    {
        min = guess;
        NextGuess();

    }

    private void NextGuess()
    {
        guess = (min + max) / 2;
        guessText.text = guess.ToString();
    }

    public void HandleLower()
    {
        max = guess;
        NextGuess();
    }
  
}
