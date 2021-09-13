using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boat : MonoBehaviour
{
    public GameObject m;
    public GameObject captain;
    public Text n;
    public Text d;
    float t = 21;
    public Text timer;
    public Image rep2;
    int check = 0;
    // Start is called before the first frame update
    void Start()
    {
        timer.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        t -=  Time.deltaTime;
        Debug.Log(t);
        if (t <= 0 && check == 0)
        {
            m.SetActive(true);
            captain.SetActive(true);
            timer.gameObject.SetActive(false);
            n.gameObject.SetActive(true);
            d.gameObject.SetActive(true);
        }
        if (rep2.gameObject.active)
        {
            check = 1;
            n.gameObject.SetActive(false);
            d.gameObject.SetActive(false);

        }
        timer.text = "Le navire arrive dans (00:" + (int)t + ")";
    }
}
