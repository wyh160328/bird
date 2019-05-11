using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int frameNumber = 10;
    public float timer;
    public int frameCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.1f / frameNumber)
        {
            frameCount++;
            frameCount %= 4 + 1;
            timer -= 0.1f / frameNumber;
            GetComponent<Renderer>().material.SetTextureOffset("_MaimTex", new Vector2(0.25f * frameCount,0));
        }
        
    }
}
