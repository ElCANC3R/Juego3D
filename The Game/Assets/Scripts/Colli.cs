using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colli : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        Debug.Log("Hola");
    }

    private void OnCollisionExit(Collision other) {
        Debug.Log("Hola");
    }
}
