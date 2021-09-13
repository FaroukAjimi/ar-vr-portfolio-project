using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    public AudioSource wfootstep;
    public AudioSource wsand;
    private AudioSource mid;

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "rock")
        {
            mid = wfootstep;
        }
        if(col.tag == "sand")
        {
            mid = wsand;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FootStep()
    {
        mid.Play();
    }
}
