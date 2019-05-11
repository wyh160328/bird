using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class bton : MonoBehaviour
{
   
    public Button enbt;
    void Start()
    {
        enbt.onClick.AddListener(sss);
    }
    public void sss()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
        //print("按钮可以使用");
    }
}
