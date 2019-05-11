using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point : MonoBehaviour
{
    public AudioClip point1;
   
   
    public void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(point1, transform.position);
        score.x += 1;
        score.txt.text = "分数：" + score.x;
    }

}

