using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class first : MonoBehaviour
{
    public Button m_YourFirstBotton;
    // Start is called before the first frame update
    void Start()
    {
        m_YourFirstBotton.onClick.AddListener(myclick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void myclick()
    {
        SceneManager.LoadScene("SampleScene_Voxel");
    }
}
