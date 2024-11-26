using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Start : MonoBehaviour
{
    public void startgame()
    {
        wrongAnswer.score = 0;
        SceneManager.LoadScene("level1Article");
    }
}