using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    public static int Score;        //�ŧi���ưѼ�
    public Text ShowScore;          //�ŧi��rUI

    
    void Start()
    {
        Score = 0;
    }


    void Update()
    {
          ShowScore.text = Score.ToString();        //��UI��r�P���ƦP�B
    }
}
