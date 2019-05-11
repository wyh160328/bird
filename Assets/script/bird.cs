using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public int frameNumber = 10;
    public float timer;
    public int frameCount = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1.0f / frameNumber)
        {
            frameCount++;
            frameCount %= 2 + 1;
            timer -= 1.0f / frameNumber;
            GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(0.3333f * frameCount, 0));
        }
    }

    

    public static void OnDisable()
    {
        
    }
}
