using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//[System.Serializable];
public class wrongAnswer : MonoBehaviour
{
    public Button[] ansbuttons;
    public int curidx;
    public string NxtQ;
    void Start()
    {
        Getrandomquestion();
    }
    void Getrandomquestion()
    {
        for (int i = 0; i < ansbuttons.Length; ++i)
        {
            int idx = i;
            ansbuttons[i].onClick.RemoveAllListeners();
            ansbuttons[i].onClick.AddListener(() => AnswerQuestion(idx));
        }
    }
    void AnswerQuestion(int selectedIndex)
    {
        if (selectedIndex == curidx)
        {
            ansbuttons[selectedIndex].GetComponent<Image>().color = Color.green;
            Invoke("LoadMiniGame", 1.2f);
        }
        else
        {
            ansbuttons[selectedIndex].GetComponent<Image>().color = Color.red;
            Invoke("LoadMiniGame", 1.2f);
        }
    }
    void LoadMiniGame()
    {
        SceneManager.LoadScene(NxtQ);
    }
}