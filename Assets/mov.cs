using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class mov : MonoBehaviour
{
    public static int Score;        //�ŧi���ưѼ�
    public Text ShowScore;          //�ŧi��rUI


    void Start()
    {
        Score = 0;
    }


    void Update()
    {
        ShowScore.text = "Step count: " + Score.ToString();        //��UI��r�P���ƦP�B
    }
   
}
