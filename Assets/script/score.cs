using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static Text txt;
    public static float x = 0;
    void Start()
    {
        txt = GameObject.Find("Text").GetComponent<Text>();
    }
}
