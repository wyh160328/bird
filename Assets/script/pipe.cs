using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        RandowY();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RandowY()
    {
        float y1 = Random.Range(0.04f, 0.4f);
        transform.localPosition = new Vector3(transform.localPosition.x, y1, transform.localPosition.z);

    }
}
