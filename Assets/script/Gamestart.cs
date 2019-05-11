using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gamestart : MonoBehaviour
{

    public Button bt;
    // Start is called before the first frame update
    void Start()
    {
        bt.onClick.AddListener(Re);
    }

    // Update is called once per frame
    public void Re()
    {
        SceneManager.LoadScene("game");
        //print("按钮可以使用");
    }
}
