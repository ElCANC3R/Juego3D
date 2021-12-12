using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        PlayerController pc = other.GetComponent<PlayerController>();

        if(pc!=null){
            Debug.Log("Llave");
            PlayerController.key=true;
            Destroy(gameObject);
        }
    }
}
