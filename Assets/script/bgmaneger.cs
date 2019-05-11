using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmaneger : MonoBehaviour
{
    public GameObject bg;

    public void OnTriggerEnter(Collider other)
    {
        Vector3 pos = transform.root.transform.position;
        pos.x += 12.29545f *2;
        Instantiate(bg, pos, Quaternion.identity);
    }
}
