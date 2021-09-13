using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quiztimer : MonoBehaviour
{
    public float dec = 30;
    public Text t;
    public Image t1;
    public Image t2;
    public Image t3;
    public Button r;
    public GameObject me;
    
    // Start is called before the first frame update
    void Start()
    {
        dec = 30;
    }

    // Update is called once per frame
    void Update()
    {
        dec -= Time.deltaTime;
        t.text = ((int)dec).ToString();
        if ((int)dec == 0)
        {
            t1.gameObject.SetActive(false);
            t2.gameObject.SetActive(false); 
            t3.gameObject.SetActive(false);
            t.gameObject.SetActive(false);
            r.gameObject.SetActive(true);
            me.SetActive(false);

        }
    }
    public void reset()
    {
        dec = 30;
    }
}
