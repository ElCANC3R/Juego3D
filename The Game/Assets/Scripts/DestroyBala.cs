using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBala : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        Destroy(gameObject);
    }
}
