using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
    public void restart1()
    {
        PlayerPrefs.SetInt("Score", 0); 
        SceneManager.LoadScene("First");
    }
}