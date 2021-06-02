using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public Transform box;
    public Color finishColor;
    public AudioSource moveAudio;
    Color originColor;
    Ray ray;
    gameManager gm;

    private void Start()
    {



        originColor = GetComponent<Renderer>().material.color;
        FindObjectOfType<gameManager>().total++;
        gm = GameObject.Find("GameManager").GetComponent<gameManager>();
    }

    public bool canMove(Vector3 dir)
    {
        RaycastHit hit;

        if (!Physics.Raycast(transform.position, dir, out hit, 0.4f) )
        {
            moveAudio.Play();
            transform.Translate(dir * 0.4f);
            return true;
        }

        return false;
    }

    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.CompareTag("Target"))
        {
            
            FindObjectOfType<gameManager>().finish++;
            FindObjectOfType<gameManager>().checkFinish();
            GetComponent<Renderer>().material.color = finishColor;
            gm.gameOver();
        }
       
    }
}
