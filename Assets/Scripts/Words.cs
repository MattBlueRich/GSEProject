using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class Words : MonoBehaviour
{
    public List<string> Adjectives;
    public List<string> Nouns;
    public List<string> TransistiveVerbs;
    public TextAsset textFile;
    // figure out how to get the max value of an array
    // Google Unity Random Random.range
    // learn how to define the size of an array
    //function MaxValue

    private void Awake()
    {
        LoadStrings();
    }

    void LoadStrings()
    {
        textFile = Resources.Load<TextAsset>("TextFiles/Adjectives"); // Loads the text file

        foreach (var myString in textFile.text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            Adjectives.Add(myString.Trim());

        textFile = Resources.Load<TextAsset>("TextFiles/Nouns");

        foreach (var myString in textFile.text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            Nouns.Add(myString.Trim());

        textFile = Resources.Load<TextAsset>("TextFiles/Verbs");

        foreach (var myString in textFile.text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            TransistiveVerbs.Add(myString.Trim());

    }

}
