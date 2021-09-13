using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;

public class distance : MonoBehaviour
{
    public Transform trigger;
    float x;
    float y;
    float z;
    float d1;
    public Text dis;
    // Start is called before the first frame update
    void Start()
    {
        x = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;
        d1 = ((trigger.position.x - x) * (trigger.position.x - x)) + ((trigger.position.y - y) * (trigger.position.y - y));
        d1 = d1 + ((trigger.position.z - z) * (trigger.position.z - z));
        d1 = Mathf.Sqrt(d1);
        d1 = (int)d1;
        dis.text = d1 + "m";
    }
}
