using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggeredEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.SendMessage("llave");
            Destroy(gameObject);
        }
    }
}
