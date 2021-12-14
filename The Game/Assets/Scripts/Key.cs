using UnityEngine;

public class Key : MonoBehaviour
{
    public Collider item;
    public AudioClip coin;
    AudioSource audioS;

    void Start(){
        audioS = GetComponent<AudioSource>(); 
    }

    private void OnTriggerEnter(Collider other) {
        PlayerController pc = other.GetComponent<PlayerController>();

        if(pc!=null){
            if(item.CompareTag("Key")){
                Debug.Log("Llave");
                PlayerController.key=true;
                audioS.PlayOneShot(coin);
                Destroy(gameObject);
              
            }
            else if(item.CompareTag("FalseKey")){
                Debug.Log("Llave Falsa");
                PlayerController.falsekey=true;
                audioS.PlayOneShot(coin);
                Destroy(gameObject);
                
            }
            else if(item.CompareTag("Item")){
                PlayerController.items++;
                Debug.Log("Llave Falsa");
                audioS.PlayOneShot(coin);
                Destroy(gameObject);
                
            }
            
        }
    }
}
