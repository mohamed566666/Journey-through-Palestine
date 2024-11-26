using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Text scoreText;

    void Start()
    {
        int finalScore = PlayerPrefs.GetInt("Score", 0);
        scoreText.text = finalScore.ToString();
    }
}
