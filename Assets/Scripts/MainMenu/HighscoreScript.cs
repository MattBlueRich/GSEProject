using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighscoreScript : MonoBehaviour
{
    public TextMeshProUGUI highscoreText;
    float highscore;

    private void Start()
    {
        highscore = PlayerPrefs.GetInt("highScore", 0);
        highscoreText.text = "Highscore: " + highscore.ToString("F0");
    }
}
