using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class end : MonoBehaviour
{
    public Button endbt;
    public AudioClip die;
    //public Button enbt;

    public void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(die, transform.position);
        endbt.transform.localPosition = new Vector3(-120, -160, endbt.transform.position.z);
        bird.OnDisable();
        Time.timeScale = 0;
        //print("游戏结束");
    }


}