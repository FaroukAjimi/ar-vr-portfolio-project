using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Formulaire : MonoBehaviour
{
    public Button re;
    public Button next;
    int score = 0;
    public Text cor;
    public Toggle t1;
    public Toggle t2;
    public Toggle t3;
    public Toggle t4;
    public Toggle t5;
    public Toggle t6;
    public Toggle t7;
    public Toggle t8;
    public Toggle t9;
    public Toggle t10;
    public Toggle t11;
    public Toggle t12;
    public Toggle t13;
    public Toggle t14;
    public Toggle t15;
    public Toggle t16;
    public Toggle t17;
    public Toggle t18;
    public Toggle t19;
    public Toggle t20;
    public Toggle t21;
    public Toggle t22;
    public Toggle t23;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void Correction()
    {
        if(t1.isOn == true && !t9.isOn && ! t10.isOn)
        {
            score += 1;
        }
        if (t2.isOn == true && !t11.isOn && !t12.isOn)
        {
            score += 1;
        }
        if (t3.isOn == true && !t13.isOn && !t14.isOn)
        {
            score += 1;
        }
        if (t4.isOn == true && !t15.isOn && !t16.isOn)
        {
            score += 1;
        }
        if (t5.isOn == true && !t17.isOn)
        {
            score += 1;
        }
        if (t6.isOn == true && !t18.isOn && !t19.isOn)
        {
            score += 1;
        }
        if (t7.isOn == true && !t20.isOn && !t21.isOn)
        {
            score += 1;
        }
        if(t8.isOn == true && !t22.isOn && !t23.isOn)
        {
            score += 1;
        }
        cor.text = score.ToString();
        if (score >= 7)
        {
            re.gameObject.SetActive(false);
            next.gameObject.SetActive(true);
        }
        else if (score < 7)
        {
            score = 0;
        }
    }
}
