using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public bool trampa;

    // Update is called once per frame
    void Update()
    {
        if(PlayerController.items >=10 && !trampa){
            Destroy(gameObject);
        }

        if(PlayerController.falsekey && trampa){
            Destroy(gameObject);
        }
    }
}
