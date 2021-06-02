using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class mov : MonoBehaviour
{
    public static int Score;        //Ω计把计
    public Text ShowScore;          //ゅUI


    void Start()
    {
        Score = 0;
    }


    void Update()
    {
        ShowScore.text = "Step count: " + Score.ToString();        //琵UIゅ籔Ω计˙
    }
   
}
