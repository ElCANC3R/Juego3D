using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disp : MonoBehaviour
{
    public Rigidbody bola;
    public float velocidad = 12f;
    private float LastShoot;
    
    void disparar(){
        Rigidbody bolaclon = (Rigidbody) Instantiate(bola,transform.position,transform.rotation);
        bolaclon.velocity=transform.forward*velocidad;
    }

    void Update() {
        if(Input.GetKey(KeyCode.Space) && Time.time > LastShoot + 0.2f){
            disparar();
            LastShoot=Time.time;
        }    
    }
}
