using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class mov : MonoBehaviour
{
    public static int Score;        //宣告次數參數
    public Text ShowScore;          //宣告文字UI


    void Start()
    {
        Score = 0;
    }


    void Update()
    {
        ShowScore.text = "Step count: " + Score.ToString();        //讓UI文字與次數同步
    }
   
}
