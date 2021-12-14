using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCoin : MonoBehaviour
{
    
    void Start()
    {
        Destroy(gameObject,1.0f);
    }

}
