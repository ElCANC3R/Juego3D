using UnityEngine;

public class Key : MonoBehaviour
{
    public Collider item;
    private void OnTriggerEnter(Collider other) {
        PlayerController pc = other.GetComponent<PlayerController>();

        if(pc!=null){
            if(item.CompareTag("Key")){
                Debug.Log("Llave");
                PlayerController.key=true;
                Destroy(gameObject);
            }
            else if(item.CompareTag("FalseKey")){
                Debug.Log("Llave Falsa");
                PlayerController.falsekey=true;
                Destroy(gameObject);
            }
            else if(item.CompareTag("Item")){
                PlayerController.items++;
                Debug.Log("Llave Falsa");
                Destroy(gameObject);
            }
            
        }
    }
}
