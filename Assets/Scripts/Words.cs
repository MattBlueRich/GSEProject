using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using TMPro;

public class Words : MonoBehaviour
{
    public List<string> Adjectives;
    public List<string> Nouns;
    public List<string> TransistiveVerbs;
    public TextAsset textFile;
    public TMP_Text fortuneText;
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

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            fortuneText.SetText(GetRandomAdjective() + " " + GetRandomVerb() + " " + GetRandomNouns());
        }
    }
    
    private string GetRandomAdjective()
    {
        var randomIndex = UnityEngine.Random.Range(0, Adjectives.Count);

        return Adjectives[randomIndex];
    }

    private string GetRandomVerb()
    {
        var randomIndex = UnityEngine.Random.Range(0, TransistiveVerbs.Count);

        return TransistiveVerbs[randomIndex];
    }

    private string GetRandomNouns()
    {
        var randomIndex = UnityEngine.Random.Range(0, Nouns.Count);

        return Nouns[randomIndex];
    }

}
