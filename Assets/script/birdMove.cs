using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class birdMove : MonoBehaviour
{
    public AudioClip wing;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(2,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AudioSource.PlayClipAtPoint(wing,transform.position);
            GetComponent<Rigidbody>().velocity = new Vector3(2, 4, 0);
        }
        
    }
   
}
