using UnityEngine;

public class Grabber : MonoBehaviour
{
    //door es una referencia al cualquier puerta con la que estemos interactuando
    public GameObject door = null;
    private Vector2 pointer;

    // Update is called once per frame
    void Update()
    {
        //Detectamos cuando el usuario ha presionado E
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (door != null)
            {

            }
            else
            {
                pointer = new Vector2(Screen.width / 2, Screen.height / 2);
                //Camera.main.ViewportToScreenPoint(new Vector3(0.5f, 0.5f, 0f))


                try
                {
                    RaycastHit hit;

                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 3f))
                    {
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) , Color.yellow);
                        //Debug.Log(hit.transform.tag);
                        if (hit.transform.tag == "Door")
                        {
                            //Debug.Log(hits[0].transform.tag);
                            door = hit.transform.gameObject;
                            door.SendMessage("OpenCloseDoor");
                            door = null;
                            //last = plat.transform.position;
                        }
                        else
                        {
                            door = null;
                        }
                    }

                }
                catch (System.Exception e)
                {
                    Debug.Log(e.StackTrace.ToString());
                }
            }

        }
    }
}
