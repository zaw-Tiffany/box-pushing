using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCount : MonoBehaviour
{
  //  public Text mov;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
         if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
         {                                        //�ʵe
             mov.Score = mov.Score + 1;
         }
         if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
         {                                //�ʵe
            mov.Score = mov.Score + 1;
         }
         if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
         {                                     //�ʵe
            mov.Score = mov.Score + 1;
         }
         if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
         {                                //�ʵe
            mov.Score =  mov.Score + 1; 
         }
         
    }
}
