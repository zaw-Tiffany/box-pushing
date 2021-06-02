using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    public static int Score;        //Ω计把计
    public Text ShowScore;          //ゅUI

    
    void Start()
    {
        Score = 0;
    }


    void Update()
    {
          ShowScore.text = Score.ToString();        //琵UIゅ籔Ω计˙
    }
}
