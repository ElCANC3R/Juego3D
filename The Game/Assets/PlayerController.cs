using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController player;
    public float speed = 3f;
    public float gravity = -9.81f;
    public static bool key = false;
    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        //Debug.Log(" X "+x+" Z " + z);
        Vector3 move = transform.right * x + transform.forward * z;
        player.Move(move * speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        player.Move(velocity * Time.deltaTime);
    }
}
