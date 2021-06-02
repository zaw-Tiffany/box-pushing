using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Transform Player;
    private Animator playerAnim;
    private Rigidbody playerRb;
    public LayerMask detectLayer;
    public AudioSource moveAudio;

    Vector3 moveDir;
    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {                                        //動畫
            moveAudio.Play();
            moveDir = Vector3.forward;
            transform.LookAt(transform.position + moveDir);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {                                //動畫
            moveAudio.Play();
            moveDir = Vector3.back;
            transform.LookAt(transform.position + moveDir);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {                                     //動畫
            moveAudio.Play();
            moveDir = Vector3.right;
            transform.LookAt(transform.position + moveDir);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {                                //動畫
            moveAudio.Play();
            moveDir = Vector3.left;
            transform.LookAt(transform.position + moveDir);
        }

        if (moveDir != Vector3.zero)
        {
            if (canMove(moveDir))
            {
                Move(moveDir);
            }
        }
        moveDir = Vector3.zero;


        /*
        //按鍵控制
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))           
        {
            Player.position += new Vector3(0, 0, 0.4f);                                 //移動
            Player.eulerAngles = new Vector3(0, 0, 0);                                  //方向
            playerAnim.SetTrigger("runTrig");                                           //動畫
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            Player.position += new Vector3(0,  0,-0.4f);
            Player.eulerAngles = new Vector3(0, 180, 0);
            playerAnim.SetTrigger("runTrig");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            Player.position += new Vector3(0.4f, 0, 0);
            Player.eulerAngles = new Vector3(0, 90, 0);
            playerAnim.SetTrigger("runTrig");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            Player.position += new Vector3(-0.4f, 0, 0);
            Player.eulerAngles = new Vector3(0, 270, 0);
            playerAnim.SetTrigger("runTrig");
        }
        */

        //邊界限制
        if (Player.position.x < -0.8)
        {
            Player.position = new Vector3(-0.8f, Player.position.y, Player.position.z);

        }
        if (Player.position.x > 1.6)
        {
            Player.position = new Vector3(1.6f, Player.position.y, Player.position.z);
        }
        if (Player.position.z > -0.4)
        {
            Player.position = new Vector3(Player.position.x, Player.position.y, -0.4f);
        }
        if (Player.position.z < -3.2)
        {
            Player.position = new Vector3(Player.position.x, Player.position.y, -3.2f);
        }
    }

    bool canMove(Vector3 dir)
    {
        if (!Physics.Raycast(transform.position, moveDir, out hit, 0.4f, detectLayer))
        {
            Debug.Log("no");
            return true;
        }
        else
        {
            Debug.Log(hit.collider.gameObject.name);
            if (hit.collider.GetComponent<Box>() != null)
            {
                return hit.collider.GetComponent<Box>().canMove(dir);
            }
        }

        return false;
    }
    void Move(Vector3 dir)
    {
        transform.Translate(dir * 0.4f,Space.World);
        playerAnim.SetTrigger("runTrig");
    }
}
