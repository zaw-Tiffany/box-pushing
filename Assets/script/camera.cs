using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform Player;
    public Vector3 offset;  
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.position+offset;
    }
}
