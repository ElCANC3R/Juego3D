using UnityEngine;

public class DoorController : MonoBehaviour
{
    //Nos dice si esta abierta o cecrrada
    public bool isOpen;
    public GameObject canvas;
    // Update is called once per frame
    void Update()
    {
        if (isOpen && PlayerController.key)
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(0, 90, 0), Time.deltaTime);
            canvas.SetActive(true);
        }
        else
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(0, 0, 0), Time.deltaTime);
        }
    }

    public void OpenCloseDoor()
    {
       isOpen = !isOpen;
    }
}