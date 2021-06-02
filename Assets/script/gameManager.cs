using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public int total=0;
    public int finish=0;
    public TextMeshProUGUI gameOverText;
    public bool isplay;
    public Button button;

    void Start()
    {
       isplay = true;
    }

    public void checkFinish()
    {
        if (finish == total)
        {
            print("Win");
            
        }
    }

    public void gameOver()
    {
        if(finish==total)
        {
            gameOverText.gameObject.SetActive(true);
            button.gameObject.SetActive(true);
        }
            
    }

    public void RestartGame()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
