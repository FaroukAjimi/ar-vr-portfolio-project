using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn : MonoBehaviour
{
    // Start is called before the first frame update
  void OnTriggerEnter(Collider col)
    {
        if (col.tag == "turn")
        {
            Debug.Log("3asba");
            transform.Rotate(0, 90, 0);
        }
    }
}
