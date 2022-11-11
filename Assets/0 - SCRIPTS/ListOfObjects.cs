using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class ListOfObjects : MonoBehaviour
{
    public int numberOfLetters;

    // Start is called before the first frame update
    private void Start()
    {
        print("Welcome to Richie's None-Existant Word Creator!!");



        List<string> strings = new List<string>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RandomConsonantChooser(10);
        }
    }

    //a word can start with either a vowel or consonant
    //the first letter of a word can begin with either 1 vowel or consonant, the second letter has to be of the opposite sort
    //after that, there can be 1 or 2 vowels or consonants in a row


    public void RandomConsonantChooser(int number)
    {
        char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        
        
        



        numberOfLetters = number;
        List<int> numberOfLettersList = new List<int>();

        int tempInt = numberOfLetters.ConvertTo<Int32>();
        numberOfLettersList.Capacity = tempInt;
        Debug.Log(numberOfLettersList.Capacity);



        for (int i = 0; i < numberOfLetters; i++)
        {
            int consonantsTemp = Random.Range(0, consonants.Length);
            int vowelsTemp = Random.Range(0, vowels.Length);

            if (numberOfLettersList[0].ToString() == consonantsTemp.ToString())
            {
                consonantsTemp.ToString();
                Debug.Log(consonants[numberOfLettersList[0]]);
            }   
            
            if (numberOfLettersList[0].ToString() == vowelsTemp.ToString())
            {
                Debug.Log(vowels[numberOfLettersList[0]]);

            }

            //return;
            //print(consonants[consonantsTemp]);
        }




    }





}